using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmITApp.Model
{
    public abstract class Animal
    {
        private long animalId;
        private string name;
        private string age;
        private string animalStatus;
        private int amountPowerfeed;
        private int amountHay;
        private int amountOats;
        private Box boxId;

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
        public string AnimalStatus
        {
            get
            {
                return animalStatus;
            }
            set
            {
                animalStatus = value;
            }
        }
        public Box BoxId{
            get
            {
                return boxId;
            }
            set
            {
                boxId = value;
            }
        }
    }
}
