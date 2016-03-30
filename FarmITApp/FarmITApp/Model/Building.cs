using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmITApp.Model
{
    public class Building
    {
        private string buildingName;
        private ICollection<Box> boxId;

        public ICollection<Box> boxList
        {
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
