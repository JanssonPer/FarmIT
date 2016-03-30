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
        private String name;
        private String age;
        private String animalStatus;
        private int amountPowerfeed;
        private int amountHay;
        private int amountOats;
        private Box boxid;

        public string Name{
            get {
                return name;
            }
            set {
                name = value;
            }
        }
        public string Age{
            get{
                return age;
            }
            set{
                age = value;
            }
        }
        public string AnimalStatus{
            get{
                return animalStatus;
            }
            set{
                animalStatus = value;
            }
        }
        public virtual Box BoxId { get; set; }

    }
}
