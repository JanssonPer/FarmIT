using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmITApp.EntityFrameworkV2;
using FarmITApp.DatabaseAccessLayer;

namespace FarmITApp.ControllerFarm
{
    public class Controller
    {
        Dal dal = new Dal();

        //Get methods
        public Animal GetAnimal(String id)
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

        public Food GetFood(String id)
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

        public Box GetBox(String id)
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

        public List<Animal> GetAllAnimals()
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
        public void FeedAllAnimals()
        {
            
                List<Animal> list = dal.GetAllAnimals();

                Food powerfeed = dal.GetFood(1);
                Food oats = dal.GetFood(2);
                Food hay = dal.GetFood(3);

                int totalPowerfeed = 0;
                int totalOats = 0;
                int totalHay = 0;

                foreach (Animal a in list)
                {
                    if (a.TypeAnimal.Equals("Horse"))
                    {
                        totalPowerfeed += (int)a.AmountOfPowerfeed;
                        totalHay += (int)a.AmountOfHay;
                    }
                    else if (a.TypeAnimal.Equals("Hen"))
                    {
                        totalOats += (int)a.AmountOfOats;
                    }
                    else
                    {
                        totalPowerfeed += (int)a.AmountOfPowerfeed;
                    }
                   
                }
            powerfeed.Amount -= totalPowerfeed;
            oats.Amount -= totalOats;
            hay.Amount -= totalHay;

            dal.UpdateFood(hay);
        }

    }
}
