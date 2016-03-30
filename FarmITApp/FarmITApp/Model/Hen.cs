using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmITApp.Model
{
    public class Hen : Animal
    {
        private int amountOats;
        public int AmountOats
        {
            get
            {
                return amountOats;
            }
            set
            {
                amountOats = value;
            }

        }
    }
}
