using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_A_Zoo.Classes
{
    class FruitBat : Bat
    {
        public override string Diet()
        {
            return "Flying Foxes generally eat nectar and pollen from flowering native trees.";
        }

        public override string WingSpan()
        {
            return "4.9 - 5.5 feet";
        }

        public string Weight()
        {
            return "1.5 - 2.1 pounds";
        }
    }
}
