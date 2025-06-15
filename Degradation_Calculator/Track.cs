namespace Degradation_Calculator
{
    //This comment is a test commit
    public class Track
    {
        public Track(string name, string location, string degragationpoint) //Track Constructor 
        {
            Name = name;
            Location = location;
            DegragationPoint = degragationpoint;

        }

        public string Name { get; private set; }
        public string Location { get; private set; }
        public string DegragationPoint { get; private set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
