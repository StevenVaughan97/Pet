using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Cat
    {
        public string name;
        public string Owner;
        public double weight;

        public Cat(string Name, string owner, double Weight)
        {

            this.name = Name;
            this.Owner = owner;
            this.weight = Weight;
        }
        public string getTag()
        {
            string lost = "If lost, call ";
            string setence = lost + this.Owner;


            return setence;
        }


        public string meow(int count)
        {
            String Meow = "Meow. ";
            if (count == 1)
            {
                return Meow;
            }
            else
            {
                int t = 2;
                while (t <= count)
                {
                    Meow = Meow + "Meow. ";
                    t++;
                }
                return Meow;

            }
        }
    }
}