using System;
using System.Collections.Generic;
using System.Text;
using I_Built_A_Zoo.Interfaces;

namespace I_Built_A_Zoo.Classes
{
    public abstract class Alligators : Reptiles, ISwim
    {
        //Properties
        public override bool LiveBirth { get; set; }
        public int WaterTemp { get; set; }
        public string Salinity { get; set; }

        //Constructor
        public Alligators()
        {
            LiveBirth = false;
            WaterTemp = 70;
            Salinity = "fresh water";
        }

        //Methods
        public override string Biome()
        {
            return $"The {Name} lives in {Salinity} enviroments such as ponds, marshes, wetlands, rivers, lakes, and swamps.";
        }

        public override string Diet()
        {
            return $"The {Name} eats large fish, turtles, mammals, birds, and other reptiles.";
        }
    }
}
