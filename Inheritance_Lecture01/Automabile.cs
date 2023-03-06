using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Lecture01
{
    class Automabile
    {
        private string make;
        private string modal;
        private int mileAge;
        private decimal price;

        public Automabile(string mk, string mdl, int mile, decimal p )
        {
            make = mk;
            modal = mdl;
            price = p;
            mileAge = mile;
        }
        public string Make { get { return make; } set { make = value; } }
        public string Modal { get { return modal; } set { modal = value; } }
        public int MileAge { get { return mileAge; } set { mileAge = value; } }
        public decimal Price { get { return price; } set { price = value; } }
    }
}
