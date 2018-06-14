using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_A_Zoo.Classes
{
    abstract class Mammals : Vertibrates
    {
        public override string Metabolism()
        {
            return "warm blooded";
        }

        public override bool LiveBirth()
        {
            return true;
        }

        public virtual string SkinCovering()
        {
            return "fur";
        }
    }
}
