using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using RegionSkane.DataAccessLayer;
using RegionSkane.Entity_Framework;

namespace RegionSkane.Utils
{
    class UiUtils
    {
        private DataAccess db = new DataAccess();

        public string OpenFileDialog()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Worksheets|*.xls;*.xlsx;*.xlsm;*.csv";
            ofd.Title = "Välj aktiv RS-lista";
           
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK){
                return ofd.FileName;
            }
            
            return null;
        }

        public List<string> OpenFolderDialog(DataSet dataSet, string contractNbr)
        {
            List<string> returnPaths = new List<string>();
            List<string> listOfSuppliers = UniqueSupplierInDataSet(dataSet);
            
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = String.Format("Välj mapp för avtal\nAvtalsnr: {0}", contractNbr);
            
            if(fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK){
                returnPaths.Add(fbd.SelectedPath);
            }

            
            foreach (string supplierNbr in listOfSuppliers)
            {
                Leverantör supplier = db.GetSupplier(supplierNbr);
                if (supplier != null)
                {
                    fbd.Description = String.Format("Välj mapp för leverantörsavtal\nLevnr: {0}\nLevnamn: {1}", supplier.Leverantörnr, supplier.Leverantörsnamn);
                }
                else
                {
                    fbd.Description = String.Format("Välj mapp för leverantörsavtal\nLevnr: {0}\nLevnamn: {1}", supplierNbr, "{namn saknas}");
                }
                
                if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    returnPaths.Add(fbd.SelectedPath);
                }
            }
            return returnPaths;
        }

        public List<string> UniqueSupplierInDataSet(DataSet ds)
        {
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
