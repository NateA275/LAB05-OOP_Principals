using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_A_Zoo.Classes
{
    public abstract class Mammals : Vertibrates
    {
        //Properties
        public override string Metabolism { get; set; }
        public override bool LiveBirth { get; set; }
        public override string SkinCovering { get; set; }

        //Constructor
        public Mammals()
        {
            Metabolism = "warm-blooded";
            LiveBirth = true;
            SkinCovering = "fur";
        }
    }
}
