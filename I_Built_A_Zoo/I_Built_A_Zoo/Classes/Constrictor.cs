using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_A_Zoo.Classes
{
    public class Constrictor : Boas
    {
        //Properties
        public override string Name { get; set; }
        public override string Size { get; set; }

        //Constructor
        public Constrictor()
        {
            Name = "Boa Constrictor";
            Size = "3 - 13 feet";
        }
    }
}
