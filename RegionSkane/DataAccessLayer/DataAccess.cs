using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegionSkane.Entity_Framework;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity;
using RegionSkane.Utils;

namespace RegionSkane.DataAccessLayer
{
    class DataAccess
    {
        
        static private ReSkEntities con = new ReSkEntities();
       
        
        //ADMINISTRATOR FUNCTIONS ************

        public Handläggare GetAdministrator(string id)
        {
            try
            {
                Handläggare h = con.Handläggare.SingleOrDefault(r => r.Id == id);
                return h;
            }
            catch
            {
                throw new RegionException(1);
            }
        }

        public List<Handläggare> GetAllAdministrators()
        {
            try
            {
                List<Handläggare> list = con.Handläggare.ToList();
                if (list.Count > 0)
                {
                    return list;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                throw new RegionException(1);
            }
        }

        public bool AddAdministrator(Handläggare h)
        {
            try
            {
                List<Handläggare> handläggarList = con.Handläggare.Where(r => r.Id == h.Id).ToList();

                if (handläggarList.Count() == 0)
                {
                    con.Handläggare.Add(h);
                    con.SaveChanges();
                    return true;
                }
                return false;

            }
            catch
            {
                con.Handläggare.Remove(h);
                throw new RegionException(1);
            }
        }

        public bool UpdateAdministrator(Handläggare h)
        {
            try
            {

                Handläggare oldAdmin = GetAdministrator(h.Id);

                con.Entry(oldAdmin).CurrentValues.SetValues(h);
                con.SaveChanges();

                return true;
            }
            catch
            {
                throw new RegionException(1);
            }
        }

        public bool DeleteAdministrator(string id)
        {
            try
            {
                List<Handläggare> list = con.Handläggare.Where(r => r.Id == id).ToList();

                if (list.Count() != 0)
                {
                    Handläggare h = con.Handläggare.First(r => r.Id == id);
                    con.Handläggare.Remove(h);
                    con.SaveChanges();
                    return true;
                }

                return false;
            }
            catch
            {
                throw new RegionException(1);
            }
        }

        //SUPPLIER FUNCTIONS *********

        public Leverantör GetSupplier(string levnr)
        {
            try
            {
                double levnrFloat = double.Parse(levnr);
                Leverantör l = con.Leverantör.Find(levnrFloat);
                return l;
            }
            catch
            {
                throw new RegionException(1);
            }
        }

        // Returns list with name for 'Artikelgrupp', 'Varugrupp' and 'Huvudgrupp' in described order.
        public List<string> GetArtNames(string dbArtNbr, string varuNbr, string huvudNbr)
        {
            try
            {
                List<string> mainList = new List<string>();
                string artName;
                string varuName;
                string huvudName;

                
                List<Artikelgrupp> aList = con.Artikelgrupp.Where(r => r.C22Artikelgrupp == dbArtNbr && r.C21Varugrupp == varuNbr && r.C20Huvudgrupp == huvudNbr).ToList();
                if (aList.Count() > 0)
                {
                    
                    foreach(Artikelgrupp a in aList)
                    {
                        artName = a.namn;
                        varuName = a.Varugrupp.namn;
                        huvudName = a.Varugrupp.Huvudgrupp.namn;

                        mainList.Add(artName);
                        mainList.Add(varuName);
                        mainList.Add(huvudName);
                    }
                    
                 
                }

                return mainList;

            }
            catch
            {
                throw new RegionException(2);
            }
        }


        

        /*

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
         * */




    }
}
