using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_A_Zoo.Classes
{
    public abstract class Reptiles : Vertibrates
    {
        //Properties
        public override string Metabolism { get; set; }
        public override string SkinCovering { get; set; }

        //Constructor
        public Reptiles()
        {
            Metabolism = "cold-blooded";
            SkinCovering = "scales";
        }
    }
}
