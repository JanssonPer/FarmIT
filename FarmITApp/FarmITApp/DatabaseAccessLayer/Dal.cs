using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmITApp.EntityFramework;

namespace FarmITApp.DatabaseAccessLayer
{
    class Dal
    {

        LabEntities context = new LabEntities();

        public Animals GetAnimal(long id)
        {
            try
            {
                Animals a = context.Animals.SingleOrDefault(r => r.IdAnimal == id);
                return a;
            }
            catch
            {
                //Exception
                return null;
            }
            
        }

        public List<Animals> GetAllAnimals()
        {
            try
            {
                List<Animals> list = context.Animals.ToList();
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
                //Exception
                return null;
            }

        }

        public List<Animals> GetAllAnimalsWhere(string status)
        {
            try
            {
                List<Animals> list = context.Animals.Where(r => r.StatusAnimal == status).ToList();
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
                //Exception
                return null;
            }

        }

        public void AddAnimal(Animals a)
        {
            try
            {
                List<Animals> list = context.Animals.Where(r => r.IdAnimal == a.IdAnimal).ToList();
                

                if (list.Count > 0)
                {
                    context.Animals.Add(a);
                    context.SaveChanges();
                }
            }
            catch
            {
                //Exception
                context.Animals.Remove(a);
            }

        }


    }
}
