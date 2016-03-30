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
        private List<Box> boxId;

        public List<Box> boxList
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
        public void AddBoxToBuilding(Box box)
        {
            boxId.Add(box);
        }
    }
}
