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
        }

        public Foods GetFood(String id)
        {
            try
            {
                long id1 = ((long)(System.Convert.ChangeType(id, typeof(long))));
                return dal.GetFood(id1);
            }
            catch
            {
                //Exception
                return null;
            }
        }

        public Boxes GetBox(String id)
        {
            try
            {
                return dal.GetBox(id);
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
                return dal.GetAllAnimals();
            }
            catch
            {
                //Exception
                return null;
            }
        }

        //Feed methods
        public void FeedAllAnimals(Foods f)
        {
            
                List<Animals> list = dal.GetAllAnimals();

                Foods powerfeed = dal.GetFood(1);
                Foods oats = dal.GetFood(2);
                Foods hay = dal.GetFood(3);

                int totalPowerfeed = 0;
                int totalOats = 0;
                int totalHay = 0;

                foreach (Animals a in list)
                {
                    if (a.TypeAnimal.Equals("Horse"))
                    {
                        totalPowerfeed += (int)a.AmountOfPowerFeed;
                        totalHay += (int)a.AmountOfHay;
                    }
                    else if (a.TypeAnimal.Equals("Hen"))
                    {
                        totalOats += (int)a.AmountOfOats;
                    }
                    else
                    {
                        totalPowerfeed += (int)a.AmountOfPowerFeed;
                    }
                    powerfeed.Amount = (int)powerfeed.Amount - totalPowerfeed;
                    oats.Amount = (int)oats.Amount - totalOats;
                    hay.Amount = (int)hay.Amount - totalHay;
                }
            }

    }
}
