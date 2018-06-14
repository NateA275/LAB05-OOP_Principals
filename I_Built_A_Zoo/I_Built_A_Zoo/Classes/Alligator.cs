using System;
using System.Collections.Generic;
using System.Text;
using I_Built_A_Zoo.Interfaces;

namespace I_Built_A_Zoo.Classes
{
    abstract class Alligator : Reptiles, ISwim
    {
        public override bool LiveBirth()
        {
            return false;
        }

        public string Salinity()
        {
            return "fresh water";
        }

        public int WaterTemp()
        {
            return 70;
        }

        public override string Biome()
        {
            return "Alligators live in freshwater enviroments, such as ponds, marshes, wetlands, rivers, lakes, and swamps.";
        }

        public override string Diet()
        {
            return "Alligators eat large fish, turtles, mammals, birds, and other reptiles.";
        }
    }
}
