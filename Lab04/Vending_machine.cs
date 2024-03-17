using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    internal class Coffee_machine
    {
        public double water, coffee, milk, chocolate;

        public object Properties { get; internal set; }

        public Coffee_machine()
        {
            water = 1000;
            coffee = 500;
            milk = 1000;
            chocolate = 500;
        }
        public bool BlackCoffee()
        {
            if (water >= 300 && coffee >= 20)
            {
                water = water - 300;
                coffee = coffee - 20;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool latte()
        {
            if (water >= 200 && coffee >= 20 && milk >= 10)
            {
                water = water - 200;
                coffee = coffee - 20;
                milk = milk - 10;
                return true;
            }

            else
            {
                return false;
            }

        }

        public bool mocca()
        {
            if (water >= 300 && coffee >= 20 && chocolate >= 10)
            {
                water = water - 300;
                coffee = coffee - 20;
                chocolate = chocolate - 10;
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool Choco()
        {
            if (water >= 300 && chocolate >= 20)
            {


                water = water - 300;
                chocolate = chocolate - 20;
                return true;
            }
            else
            {
                return false;
            }

        }
    }

}
