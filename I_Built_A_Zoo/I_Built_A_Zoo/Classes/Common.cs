using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_A_Zoo.Classes
{
    public class Common : Loons
    {
        //Properties
        public override string Name { get; set; }
        public override string WingSpan { get; set; }
        public override string Size { get; set; }

        //Constructor
        public Common()
        {
            Name = "Common Loon";
            WingSpan = "50 - 62 inches";
            Size = $"7.1 - 9 pounds, with a wingspan of {WingSpan}";
        }
    }
}
