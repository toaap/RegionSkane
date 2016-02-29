using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Extra namespaces
using RegionSkane.Entity_Framework;
using RegionSkane.DataAccessLayer;

namespace RegionSkane.Controller
{
    class EntityController
    {
        private DataAccess dal = new DataAccess();

        public bool UpdateAdministrator(Handläggare h){
            return dal.UpdateAdministrator(h);
        }

        public bool AddAdministrator(Handläggare h)
        {
            return dal.AddAdministrator(h);
        }

        public Handläggare GetAdministrator(string id)
        {
            return dal.GetAdministrator(id);
        }
        public List<Handläggare> GetAllAdministrators()
        {
            return dal.GetAllAdministrators();
        }

        public bool DeleteAdministrator(string id)
        {
            return dal.DeleteAdministrator(id);
        }
    }
}
