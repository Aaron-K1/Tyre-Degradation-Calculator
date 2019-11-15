using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renault_F1_Application
{
    //This comment is a test commit
    public class Track
    {
        public string Name { get; private set; }
        public string Location { get; private set; }
        public string DegragationPoint { get; private set; }

        public Track(string name, string location, string degragationpoint) //Track Constructor 
        {
            Name = name;
            Location = location;
            DegragationPoint = degragationpoint;

        }

        public override string ToString()
        {
            return Name;
        }
    }
}
