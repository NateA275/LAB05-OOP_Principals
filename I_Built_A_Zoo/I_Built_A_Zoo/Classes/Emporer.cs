using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_A_Zoo.Classes
{
    public class Emporer : Penguins
    {
        //Properties
        public override string Name { get; set; }
        public override int WaterTemp { get; set; }
        public override string Size { get; set; }

        //Constructor
        public Emporer()
        {
            Name = "Emporer Penguin";
            WaterTemp = 28;
            Size = "3.6 - 4.3 feet";
        }
    }
}
