using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingManagementApplication
{
    internal class ShiftData
    {
        public string idShift;
        public string name;
        public TimeSpan startingTime;
        public TimeSpan endingTime;
        
        public ShiftData(string idShift, string name, TimeSpan startingTime, TimeSpan endingTime)
        {
            this.idShift = idShift;
            this.name = name;
            this.startingTime = startingTime;
            this.endingTime = endingTime;
        }

        public ShiftData()
        {
        }
    }
}
