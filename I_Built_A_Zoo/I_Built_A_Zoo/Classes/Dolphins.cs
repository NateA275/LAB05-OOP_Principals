using System;
using System.Collections.Generic;
using System.Text;
using I_Built_A_Zoo.Interfaces;

namespace I_Built_A_Zoo.Classes
{
    public abstract class Dolphins : Mammals, ISwim
    {
        public override string SkinCovering { get; set; }
        public abstract int WaterTemp { get; set; }
        public abstract string Salinity { get; set; }

        //Constructor
        public Dolphins()
        {
            SkinCovering = "none";
        }

        //Methods
        public override string FamilyUnit()
        {
            return $"The {Name} lives in family units called 'pods'.";
        }

        public override string Biome()
        {
            return $"The {Name} inhabits all of the oceans on this planet, and even some rivers!";
        }

        public override string Diet()
        {
            return $"The {Name} mostly eats fish, and sometimes also eats squid.";
        }
    }
}
