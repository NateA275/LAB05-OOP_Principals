﻿using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_A_Zoo.Classes
{
    public class American : Alligators
    {
        //Properties
        public override string Name { get; set; }
        public override string Size { get; set; }

        //Constructor
        public American()
        {
            Name = "American Alligator";
            Size = "8.5 - 15 feet";
        }
    }
}
