﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegionSkane.Utils;
using System.Data;

namespace RegionSkane.Controller
{
    class RegionController
    {
        RegionUtils dal = new RegionUtils();

        public string HelloWorld()
        {
            return dal.HelloWorld();
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