using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_A_Zoo.Classes
{
    abstract class Reptiles : Vertibrates
    {
        public override string Metabolism()
        {
            return "cold blooded";
        }

        public string SkinCovering()
        {
            return "scales";
        }
    }
}
