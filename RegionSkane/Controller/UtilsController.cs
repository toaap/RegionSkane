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
    class UtilsController
    {
        ExcelUtils excelUtils = new ExcelUtils();
        DataAccess entityDb = new DataAccess();
        PrintUtils printUtils = new PrintUtils();
        UiUtils uiUtils = new UiUtils();

        public bool CheckEqualsTablesPath(DataSet dataSet, List<string> paths)
        {
            return excelUtils.CheckEqualsTablesPath(dataSet, paths);
        }
        
        public DataSet LoadDataSetWithNameFromDb(DataSet dataSet)
        {
            return excelUtils.AddArtNameFromDb(dataSet);
        }

        
        public List<string> OpenFolderDialog(DataSet dataSet, string contractNbr)
        {
            return uiUtils.OpenFolderDialog(dataSet, contractNbr);
        }

        public DataSet GetPrintSets(DataSet data)
        {
            return excelUtils.GetPrintSets(data);
        }

        public DataTable ListOfSuppliersToDataTable(DataSet ds)
        {
            return excelUtils.ListOfSuppliersToDataTable(ds);
        }

        public DataSet AddColumnData(DataSet dataSet, DataTable newData)
        {
            return excelUtils.AddColumnData(dataSet, newData);
        }

        public DataSet ReadExcelToDataSet(string artNr)
        {
            return excelUtils.ReadExcelFile(artNr);
        }

        public DataTable GetCompanyArt(string companyName, DataSet dataSet)
        {
            return excelUtils.GetLevArticles(companyName,dataSet);
        }

        public void CreatePdfDocuments(DataSet dataSet, List<string> savePathList, string contractNbr)
        {
            //, Handläggare handläggare, string startDate, string endDate
            printUtils.CreatePdfDocuments(dataSet, savePathList, contractNbr);
        }
    }
}
