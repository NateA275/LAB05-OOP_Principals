using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_A_Zoo.Classes
{
    public class FruitBat : Bats
    {
        //Properties
        public override string Name { get; set;  }
        public override string WingSpan { get; set; }
        public override string Size { get; set; }

        //Constructor
        public FruitBat()
        {
            Name = "Flying Fox";
            WingSpan = "4.9 - 5.5 feet";
            Size = $"1.5 - 2.1 pounds, with a wingspan of {WingSpan}";
        }

        //Methods
        public override string Diet()
        {
            return $"The {Name} generally eats nectar and pollen from flowering native trees.";
        }
    }
}
