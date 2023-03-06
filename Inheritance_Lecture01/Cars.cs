using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Lecture01
{
    class Cars:Automabile
    {
        private int doors;
        public Cars(int d, string make, string modal, int mile, decimal price)
            :base(make, modal, mile, price)
        {
            doors = d;
        }
        public int Doors { get; set; }
    }
}
