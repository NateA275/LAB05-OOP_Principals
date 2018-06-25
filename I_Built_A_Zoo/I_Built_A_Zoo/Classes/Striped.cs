using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_A_Zoo.Classes
{
    public class Striped : Dolphins
    {
        //Properties
        public override string Name { get; set; }
        public override int WaterTemp { get; set; }
        public override string Salinity { get; set; }
        public override string Size { get; set; }

        //Constructor
        public Striped()
        {
            Name = "Striped Dolphin";
            WaterTemp = 70;
            Salinity = "salt water";
            Size = "7 - 9 feet";
        }
    }
}
