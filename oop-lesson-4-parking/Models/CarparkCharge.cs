using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking
{
    public class CarparkCharge
    {
        public int minimumFee { get; set; }
        public int minimumHours { get; set; }
        public CarparkCharge(int _minimumFee = 2, int _minimumHours = 3)
        {
            minimumFee = _minimumFee;
            minimumHours = _minimumHours;
            Console.WriteLine("Starting CarparkCharge Class");
        }

        public override string ToString()
        {
            return "---------------------CarparkCharge";
        }

        public int CalculateCharge(int hoursParked)
        {


            return hoursParked * minimumFee;

        }
    }
}
