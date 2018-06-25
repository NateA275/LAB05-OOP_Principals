using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_A_Zoo.Classes
{
    public class Chinese : Alligators
    {
        //Properties
        public override string Name { get; set; }
        public override string Size { get; set; }

        //Constructor
        public Chinese()
        {
            Name = "Chinese Alligator";
            Size = "5 - 7 feet";
        }
    }
}
