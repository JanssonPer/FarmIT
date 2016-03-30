using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmITApp.Model
{
    public class Horse : Animal
    {
        private int amountPowerfeed;
        private int amountHay;

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
        public int AmountHay
        {
            get
            {
                return amountHay;
            }
            set
            {
                amountHay= value;
            }

        }
    }
}
