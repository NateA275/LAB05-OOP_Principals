using System;
using System.Collections.Generic;
using System.Text;
using I_Built_A_Zoo.Interfaces;

namespace I_Built_A_Zoo.Classes
{
    public abstract class Penguins : Birds, ISwim
    {
        //Properties
        public string Salinity { get; set; }
        public abstract int WaterTemp { get; set; }

        //Constructor
        public Penguins()
        {
            Salinity = "salt water";
        }

        //Methods
        public override string FamilyUnit()
        {
            return $"While on land the family unit of the {Name} is called a 'waddle'. In the water they are a 'raft'.";
        }

        public override string Diet()
        {
            return $"The {Name} eats squid, krill, and crustaceans, but most of their diet is fish.";
        }

        public override string Biome()
        {
            return $"The {Name} can be found in Antarctica, temperate islands near the equator, South Africa, and Austrailia. They prefer {Salinity}";
        }

    }
}
