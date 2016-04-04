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


        // Get Methods 
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

        public Foods GetFood(long id)
        {
            try
            {
                Foods f = context.Foods.SingleOrDefault(r => r.IdFood == id);
                return f;
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
                Boxes b = context.Boxes.SingleOrDefault(r => r.IdBox == id);
                return b;
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

        //Add Methods

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

        // Remove methods

        public void RemoveAnimal(Animals a)
        {
            try
            {
                List<Animals> list = context.Animals.Where(r => r.IdAnimal == a.IdAnimal).ToList();

                if (list.Count > 0)
                {
                    context.Animals.Remove(a);
                    context.SaveChanges();
                }
            }
            catch
            {
                //Exception
                context.Animals.Remove(a);
            }

        }

        //Update Methods

        public void UpdateAnimal(Animals a)
        {
            try
            {
                Animals oldAnimal = GetAnimal(a.IdAnimal);

                if (oldAnimal != null)
                {
                    context.Entry(oldAnimal).CurrentValues.SetValues(a);
                    context.SaveChanges();
                   
                }
            }
            catch 
            {
                //Exception
                context.Animals.Remove(a);

            }

        }

        public void UpdateBox(Boxes b)
        {
            try
            {
                Boxes oldBox = GetBox(b.IdBox);

                if (oldBox != null)
                {
                    context.Entry(oldBox).CurrentValues.SetValues(b);
                    context.SaveChanges();

                }
            }
            catch
            {
                //Exception
                context.Boxes.Remove(b);

            }

        }
        //Feed Animals

        public void AddFoodAmount(Foods f)
        {
            try
            {
                Foods oldFood = GetFood(f.IdFood);
               

                if (oldFood != null)
                f.Amount += oldFood.Amount;


                {
                    context.Entry(oldFood).CurrentValues.SetValues(f);
                    context.SaveChanges();
                }
            }
            catch
            {
                //Exception
                context.Foods.Remove(f);

            }

        }
        
    }
}
