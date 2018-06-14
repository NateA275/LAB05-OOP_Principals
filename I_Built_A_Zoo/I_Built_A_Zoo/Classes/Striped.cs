using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_A_Zoo.Classes
{
    class Striped : Dolphin
    {
        public override string Salinity()
        {
            return "salt water";
        }

        public override int WaterTemp()
        {
            return 70;
        }

        public string Length()
        {
            return "7 - 9 feet";
        }
    }
}
