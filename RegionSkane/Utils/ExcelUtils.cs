using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using MigraDoc;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.DocumentObjectModel.IO;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.Rendering;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using RegionSkane.DataAccessLayer;
using RegionSkane.Entity_Framework;

namespace RegionSkane.Utils
{
    class ExcelUtils
    {
        private DataAccess dal = new DataAccess();
        private UiUtils ui = new UiUtils();

        private string GetConnectionString()
        {
            string filename = ui.OpenFileDialog();

            if (filename == null)
            {
                return null;
            }

            Dictionary<string, string> props = new Dictionary<string, string>();

            // XLSX - Excel 2007, 2010, 2012, 2013
            props["Provider"] = "Microsoft.ACE.OLEDB.12.0;";
            props["Extended Properties"] = "Excel 12.0 XML";
            props["Data Source"] = filename;

            // XLS - Excel 2003 and Older    c:\\RS Lista original Rev 150505 ex t projekt.xlsx
            //props["Provider"] = "Microsoft.Jet.OLEDB.4.0";
            //props["Extended Properties"] = "Excel 8.0";
            //props["Data Source"] = "C:\\MyExcel.xls";

            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<string, string> prop in props)
            {
                sb.Append(prop.Key);
                sb.Append('=');
                sb.Append(prop.Value);
                sb.Append(';');
            }

            return sb.ToString();
        }

        public DataSet ReadExcelFile(string avtalsNr)
        {
            string connectionString = GetConnectionString();

            if (connectionString == null)
            {
                return null;
            }

            DataSet ds = new DataSet();

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                //Kolla om conn.open fungerar == false så betyder det att nån annan redigerar RS-listan
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                
                // Get all Sheets in Excel File
                DataTable dtSheet = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                string newSheetName = "table";
                int sheetNumber = 0;

                string selectTags =  "[01Artikelnr RS],[06Benämning 1],[07Benämning 2],[08ProdNamn]," +
                                     "[09LevArtNr],[10LevNr],[12MBE Lev],[13MBE Kund],[14TrspFp],[15PallFp],[16Enhet]," +
                                     "[17PrisPerEnhet],[18Momssats],[19Regions kod],[20Huvudgrupp],[21Varugrupp],[22Artikelgrupp],[23Lagertyp]," +
                                     "[24Ledtid Lev],[25BerFörbr],[26ÄndrBeskr],[27Reg# art#konto],[28Ändringshändelse]," +
                                     "[29Avtalsnr],[30Lagerställe/Krav],[31Mrp-kod],[Pos# Nr],[Tillv# Land],[Valuta]," +
                                     "[Avd, Fp],[Anmärkningar],[Produktleverantör]";
                
                // Loop through all Sheets to get data
                foreach (DataRow dr in dtSheet.Rows)
                {
                    string sheetName = dr["TABLE_NAME"].ToString();
                        string excelSql = "";

                        if (sheetName.Equals("Original$"))
                        {
                            //excelSql = "SELECT " + selectTags + " FROM [" + sheetName + "] WHERE [29Avtalsnr] LIKE '" + avtalsNr + "'";
                            excelSql = "SELECT " + selectTags + " FROM [" + sheetName + "] WHERE [29Avtalsnr] LIKE @_avtalsnr";
                            
                            // Get all rows from the Sheet
                            cmd.CommandText = excelSql;
                            DataTable dt = new DataTable();
                            dt.TableName = newSheetName + sheetNumber;
                            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                            da.SelectCommand.Parameters.Add("@_avtalsnr", OleDbType.Char).Value = avtalsNr;
                            da.Fill(dt);
                            ds.Tables.Add(dt);
                        }
                        
                        //används aldrig
                        if (avtalsNr == null || avtalsNr == String.Empty || excelSql.Equals(""))
                        {
                            excelSql = "SELECT * FROM [" + sheetName + "]";
                        }

                        sheetNumber++;
                }

                cmd = null;
                conn.Close();
            }

            return ds;
        }

        //Checks if there are equal amount of paths and pdf-printsets True == equals
        public bool CheckEqualsTablesPath(DataSet dataSet, List<string> paths)
        {
            if (dataSet.Tables.Count == paths.Count)
            {
                return true;
            }

            return false;
        }

        //Get pdf-printsets ready for print
        public DataSet GetPrintSets(DataSet dataSet)
        {
            if (dataSet != null)
            {
                List<string> listOfSuppliers = UniqueSupplierInDataSet(dataSet);

                string nameOfTable = "pdftable";
                int i = 1;

                DataSet newDataSet = dataSet.Clone();
                DataTable dt = dataSet.Tables["table1"];


                DataTable allDataDt = dt.Copy();
                allDataDt.TableName = nameOfTable + i++;
                allDataDt = SortTable(allDataDt);
                newDataSet.Tables.Add(allDataDt);
                

                foreach(string supplier in listOfSuppliers)
                {
                    //Copies structure of dt
                    DataTable newDt = dt.Clone();
                    newDt.TableName = nameOfTable + i++;

                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["10LevNr"].ToString().Equals(supplier))
                        {
                            newDt.Rows.Add(row.ItemArray);
                        }
                    }

                    //Sort function
                    newDt = SortTable(newDt);

                    //Adds new DataTable to DataSet for each Supplier
                    newDataSet.Tables.Add(newDt);
                }

                newDataSet.Tables.Remove("table1");

                return newDataSet;
            }
            
            return null;
        }

        //Sort lists on columns
        public DataTable SortTable(DataTable table)
        {
            table.DefaultView.Sort = "20Huvudgrupp ASC, 21Varugrupp DESC";
            table = table.DefaultView.ToTable();
            return table;
        }

        //Mapping column 'Löpnummer' provided by user with whole DataSet
        public DataSet AddColumnData(DataSet dataSet, DataTable newData)
        {
            DataTable dt = dataSet.Tables["table1"];
            dt.Columns.Add("Löpnummer");
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataRow newRow in newData.Rows)
                {
                    if (row["10LevNr"].ToString().Equals(newRow["Leverantörsnr"].ToString()))
                    {
                        row.BeginEdit();
                        row["Löpnummer"] = newRow["Löpnummer"];
                        row.AcceptChanges();
                    }
                }
            }

            /*
            dt's dataSet is already set to the incoming dataSet. 
            Thats why we return the old dataSet after changes are made
            */

            return dataSet;
        }

        
        //Returns DataSet with 'artikelsgruppsnamn','huvudgruppnamn' and 'varugruppnamn'
        public DataSet AddArtNameFromDb(DataSet dataSet)
        {
            DataTable dt = dataSet.Tables["table1"];
            dt.Columns.Add("Artikelgruppnamn");
            dt.Columns.Add("Varugruppnamn");
            dt.Columns.Add("Huvudgruppnamn");
            
            foreach (DataRow row in dt.Rows)
            {
                string artNbr = row["22Artikelgrupp"].ToString();
                string varuNbr = row["21Varugrupp"].ToString();
                string huvudNbr = row["20Huvudgrupp"].ToString();

                //ArticleNbr are saved in DB as VaruNbr + artNbr example: [0145] varu=01 art=45
                string dbArtNbr = varuNbr + artNbr;

                List<string> list = dal.GetArtNames(dbArtNbr, varuNbr, huvudNbr);

                if (list.Count > 0)
                {
                    row.BeginEdit();
                    row["Artikelgruppnamn"] = list[0];
                    row["Varugruppnamn"] = list[1];
                    row["Huvudgruppnamn"] = list[2];
                    row.AcceptChanges();
                }
               
            }

            return dataSet;
        }

        //Returns DataTable for interaction regarding 'Löpnummer'
        public DataTable ListOfSuppliersToDataTable(DataSet dataset)
        {
            List<string> listOfSuppliers = UniqueSupplierInDataSet(dataset);
            DataTable returnDt = new DataTable();
            returnDt.Columns.Add("Leverantörsnr");
            returnDt.Columns.Add("Leverantör");
            returnDt.Columns.Add("Löpnummer");

            foreach (string supplier in listOfSuppliers)
            {
                DataRow supplierRow = returnDt.NewRow();
                supplierRow["Leverantörsnr"] = supplier;

                Leverantör l = dal.GetSupplier(supplier);

                if (l != null)
                {
                    supplierRow["Leverantör"] = l.Leverantörsnamn;
                }
                else
                {
                    supplierRow["Leverantör"] = "Inget namn";
                }
                
                returnDt.Rows.Add(supplierRow);
            }

            return returnDt;
        }

        public DataTable GetLevArticles(string levNr, DataSet dataSet)
        {

            DataTable dt = dataSet.Tables["table1"];
            DataTable returnDt = new DataTable();

            foreach (DataColumn column in dt.Columns)
            {
                returnDt.Columns.Add(column.ColumnName);
            }
            //Adds löpnr column
            returnDt.Columns.Add("Löpnr");

            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row["10LevNr"].ToString().Equals(levNr))
                    {
                        DataRow artRow = returnDt.NewRow();

                        foreach (DataColumn column in returnDt.Columns)
                        {
                            if (column.ColumnName.Equals("Löpnr"))
                            {
                                artRow["Löpnr"] = "";
                            }
                            else
                            {
                                artRow[column.ColumnName] = row[column.ColumnName];
                            }
                        }
                        returnDt.Rows.Add(artRow);
                    }
                }
            }
            return returnDt;
        }

        public List<string> UniqueSupplierInDataSet(DataSet ds){
            DataTable dt = ds.Tables["table1"];
            List<string> list = new List<string>();
            List<string> returnList = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
                string supplier = row["10LevNr"].ToString();
                list.Add(supplier);
            }

            returnList = list.Distinct().ToList();
            return returnList;
        }


        

    }
}
