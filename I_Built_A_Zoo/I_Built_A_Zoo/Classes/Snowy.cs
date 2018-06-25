using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_A_Zoo.Classes
{
    public class Snowy : Owls
    {
        //Properties
        public override string Name { get; set; }
        public override string WingSpan { get; set; }
        public override string Size { get; set; }

        //Constructor
        public Snowy()
        {
            Name = "Snowy Owl";
            WingSpan = "49 - 59 inches";
            Size = $"3.5 - 6.6 pounds, with a wingspan of {WingSpan}";
        }
    }
}
