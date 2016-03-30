using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmITApp.Model
{
    public class Pig : Animal
    {
        private int amountPowerfeed;

        public int AmountPowerfeed
        {
            get
            {
                return amountPowerfeed;
            }
            set
            {
                amountPowerfeed = value;
            }
            
        }
    }
}
