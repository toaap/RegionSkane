using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegionSkane.Entity_Framework;
using System.Data;
using System.Data.SqlClient;

namespace RegionSkane.DataAccessLayer
{
    class DataAccess
    {
        private RegionServiceEntity con = new RegionServiceEntity();

        public void AddHandläggare(Handläggare h)
        {
            try
            {
                List<Handläggare> handläggarList = con.Handläggare.Where(r => r.HandläggarId == h.HandläggarId).ToList();

                if (handläggarList.Count() == 0)
                {
                    con.Handläggare.Add(h);
                    con.SaveChanges();
                }

            }catch(InvalidOperationException)
            {
                con.Handläggare.Remove(h);
                //throw new DatabaseException("Databasfel, kontakta systemadminstratör!");
            }
        }

        public void InsertIntoMembers(DataTable dataTable)
        {
            using (var connection = new SqlConnection(@"Data Source=ServerName;Server=localhost;persist security info=True;Integrated Security=SSPI;Initial Catalog=RegionService;;MultipleActiveResultSets=True;App=EntityFramework"))
            {
                SqlTransaction transaction = null;
                connection.Open();
                try
                {
                    transaction = connection.BeginTransaction();
                    using (var sqlBulkCopy = new SqlBulkCopy(connection, SqlBulkCopyOptions.TableLock, transaction))
                    {
                        sqlBulkCopy.DestinationTableName = "Artikel";
                        sqlBulkCopy.ColumnMappings.Add("01Artikelnr RS", "01Artikelnr RS");
                        sqlBulkCopy.WriteToServer(dataTable);
                    }
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }

            }
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



    }
}
