using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_A_Zoo.Classes
{
    public abstract class Birds : Vertibrates
    {
        //Properties
        public override string Metabolism { get; set; }
        public override bool LiveBirth { get; set; }
        public override string SkinCovering { get; set; }

        //Constructor
        public Birds()
        {
            Metabolism = "warm-blooded";
            LiveBirth = false;
            SkinCovering = "feathers";
        }
    }
}
