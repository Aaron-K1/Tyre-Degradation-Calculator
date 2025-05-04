using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degradation_Calculator
{
    public class Tyre
    {
        public string Name { get; private set; }
        public string Family { get; private set; }
        public string Type { get; private set; }
        public string Placement { get; private set; }
        public double DegradationCoefficient { get; private set; }

        public Tyre(string name, string family, string type, string placement, double degradationcoefficient) //Tyre constructor
        {
            Name = name;
            Family = family;
            Type = type;
            Placement = placement;
            DegradationCoefficient = degradationcoefficient;
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
