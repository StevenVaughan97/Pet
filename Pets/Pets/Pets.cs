using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Pet
    {
        public string Type;
        public string name;
        public string Owner;
        public double weight;

        public Pet(string type, string Name, string owner, double Weight)
        {
            this.Type = type;
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
    }
}