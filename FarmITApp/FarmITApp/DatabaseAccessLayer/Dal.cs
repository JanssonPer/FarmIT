using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmITApp.Model;

namespace FarmITApp.DatabaseAccessLayer
{
    class Dal
    {

        FarmEntities context = new FarmEntities();


        // Get Methods 
        public Animal GetAnimal(long id)
        {
            try
            {
                Animal a = context.Animal.SingleOrDefault(r => r.IdAnimal == id);
                return a;
            }
            catch
            {
                //Exception
                return null;
            }

        }

        public Food GetFood(long id)
        {
            try
            {
                Food f = context.Food.SingleOrDefault(r => r.IdFood == id);
                return f;
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
                Box b = context.Box.SingleOrDefault(r => r.IdBox == id);
                return b;
            }
            catch
            {
                //Exception
                return null;
            }

        }

        public Building GetBuilding(String id)
        {
            try
            {
                Building b = context.Building.SingleOrDefault(r => r.IdBuilding == id);
                return b;
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
                List<Animal> list = context.Animal.ToList();
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

        public List<Food> GetAllFood()
        {
            try
            {
                List<Food> list = context.Food.ToList();
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

        public List<Box> GetAllBoxes()
        {
            try
            {
                List<Box> list = context.Box.ToList();
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

            public List<Building> GetAllBuildings()
        {
            try
            {
                List<Building> list = context.Building.ToList();
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

    public List<Animal> GetAllAnimalsWhere(string status)
    {
        try
        {
            List<Animal> list = context.Animal.Where(r => r.StatusAnimal == status).ToList();
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
        

        public List<Animal> GetAnimalsByType(string type)
        {
            try
            {
                List<Animal> list = context.Animal.Where(r => r.TypeAnimal == type).ToList();

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

        public List<Animal> GetAnimalsById(long id)
        {
            try
            {
                List<Animal> list = context.Animal.Where(r => r.IdAnimal == id).ToList();

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

        public void AddAnimal(Animal a)
        {
            try
            {
                List<Animal> list = context.Animal.Where(r => r.IdAnimal == a.IdAnimal).ToList();

                if (list.Count == 0)
                {
                    context.Animal.Add(a);
                    context.SaveChanges();
                }
            }
            catch
            {
                //Exception
                context.Animal.Remove(a);
            }

        }

        // Remove methods

        public void RemoveAnimal(Animal a)
        {
            try
            {
                List<Animal> list = context.Animal.Where(r => r.IdAnimal == a.IdAnimal).ToList();

                if (list.Count > 0)
                {
                    context.Animal.Remove(a);
                    context.SaveChanges();
                }
            }
            catch
            {
                //Exception
                context.Animal.Remove(a);
            }

        }

        //Update Methods

        public void UpdateAnimal(Animal a)
        {
            try
            {
                Animal oldAnimal = GetAnimal(a.IdAnimal);

                if (oldAnimal != null)
                {
                    context.Entry(oldAnimal).CurrentValues.SetValues(a);
                    context.SaveChanges();

                }
            }
            catch
            {
                //Exception
                context.Animal.Remove(a);

            }

        }

        public void UpdateFood(Food f)
        {
            try
            {
                Food oldFood = GetFood(f.IdFood);

                if (oldFood != null)
                {
                    context.Entry(oldFood).CurrentValues.SetValues(f);
                    context.SaveChanges();

                }
            }
            catch
            {
                //Exception
                context.Food.Remove(f);

            }

        }

        public void UpdateBox(Box b)
        {
            try
            {
                Box oldBox = GetBox(b.IdBox);

                if (oldBox != null)
                {
                    context.Entry(oldBox).CurrentValues.SetValues(b);
                    context.SaveChanges();

                }
            }
            catch
            {
                //Exception
                context.Box.Remove(b);

            }

        }
        //Feed Animals

        public void AddFoodAmount(Food f)
        {
            try
            {
                Food oldFood = GetFood(f.IdFood);


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
                context.Food.Remove(f);

            }
        }
    }
}
