using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmITApp.Model
{
    public abstract class Animal
    {
        private long idAnimal;
        private String name;
        private String age;
        private String statusAnimal;
        private Box box;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string StatusAnimal
        {
            get
            {
                return statusAnimal;
            }
            set
            {
                statusAnimal = value;
            }
        }
        public Box 
        {
            get
            {
                return box;
            }
    set
            {
                box = value;
            }
        }

    }
}
