using System;
using System.Collections.Generic;
using System.Text;
using I_Built_A_Zoo.Interfaces;

namespace I_Built_A_Zoo.Classes
{
    abstract class Penguin : Birds, ISwim
    {
        public string Salinity()
        {
            return "Salt Water";
        }

        public abstract int WaterTemp();

        public override string FamilyUnit()
        {
            return "A group of penguins on land is called a 'waddle'. In the water they are a 'raft'.";
        }

        public override string Diet()
        {
            return "Penguins eat squid, krill, and crustaceans, but most of their diet is fish.";
        }

        public override string Biome()
        {
            return "All penguins live naturally in the southern hemisphere. They can be found in Antarctica, temperate islands near the equator, South Africa, and Austrailia.";
        }
    }
}
