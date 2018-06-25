using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_A_Zoo.Classes
{ 
    public class Screech : Owls
    {
        //Properties
        public override string Name { get; set; }
        public override string WingSpan { get; set; }
        public override string Size { get; set; }

        //Constructor
        public Screech()
        {
            Name = "Screech Owl";
            WingSpan = "18 - 24 inches";
            Size = $"4.3 - 8.6 ounces, with a wingspan of {WingSpan}";
        }
    }
}
