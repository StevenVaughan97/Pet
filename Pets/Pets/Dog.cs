using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Dog
    {

        public string name;
        public string Owner;
        public double weight;

        public Dog(string Name, string owner, double Weight)
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


        public string bark(int count)
        {
            String Bark = "Bark! ";
            if (count == 1)
            {
                return Bark;
            }
            else
            {
                int t = 2;
                while (t <= count)
                {
                    Bark = Bark + "Bark! ";
                    t++;
                }
                return Bark;

            }
        }
    }
}