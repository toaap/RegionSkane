using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegionSkane.Utils;
using System.Data;
using RegionSkane.DataAccessLayer;
using RegionSkane.Entity_Framework;

namespace RegionSkane.Controller
{
    class RegionController
    {
        RegionUtils dal = new RegionUtils();
        DataAccess db = new DataAccess();

        public void AddHandläggare(DataTable dt)
        {
            db.InsertIntoMembers(dt);
        }

        public List<string> AmountOfSuppliers(DataSet ds)
        {
            return dal.UniqueSupplierInDataSet(ds);
        }

        public void printSamplePdf(string companyName, string text)
        {
            dal.printSamplePdf(companyName, text);
        }

        public string[] createRoot(string companyName)
        {
            return dal.CreateRootPath(companyName, DateTime.Now);
        }

        public DataSet ReadExcelToDataSet(string artNr)
        {
            return dal.ReadExcelFile(artNr);
        }

        public DataTable GetCompanyArt(string companyName, DataSet dataSet)
        {
            return dal.GetLevArticles(companyName,dataSet);
        }

        public void Crud(DataTable dt)
        {
            dal.CreateDocument(dt);
        }
    }
}
