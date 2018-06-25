using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_A_Zoo.Classes
{
    public class King : Penguins
    {
        //Properties
        public override string Name { get; set; }
        public override int WaterTemp { get; set; }
        public override string Size { get; set; }

        //Constructor
        public King()
        {
            Name = "King Penguin";
            WaterTemp = 48;
            Size = "28 - 39 inches";
        }
    }
}
