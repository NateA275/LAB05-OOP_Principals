using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_A_Zoo.Classes
{
    abstract class Birds : Vertibrates
    {
        public override string Metabolism()
        {
            return "warm blooded";
        }

        public override bool LiveBirth()
        {
            return false;
        }

        public string SkinCovering()
        {
            return "feathers";
        }
    }
}
