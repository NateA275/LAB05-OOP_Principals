using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_A_Zoo.Classes
{
    public class Bottlenose : Dolphins
    {
        //Properties
        public override string Name { get; set; }
        public override string Salinity { get; set; }
        public override int WaterTemp { get; set; }
        public override string Size { get; set; }

        //Constructor
        public Bottlenose()
        {
            Name = "Bottle Nosed Dolphin";
            Salinity = "salt water";
            WaterTemp = 70;
            Size = "6.6 - 13 feet";
        }
    }
}
