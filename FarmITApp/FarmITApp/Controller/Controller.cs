using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmITApp.EntityFramework;
using FarmITApp.DatabaseAccessLayer;

namespace FarmITApp.Controller
{
    public class Controller
    {
        Dal dal = new Dal();

        //Get methods
        public Animals GetAnimal(String id)
        {
            try
            {
                long id1 = ((long)(System.Convert.ChangeType(id, typeof(long))));
                return dal.GetAnimal(id1);
            }
            catch
            {
                //Exception
                return null;
            }
        }suck
    }
}
