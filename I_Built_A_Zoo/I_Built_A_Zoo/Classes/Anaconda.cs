using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_A_Zoo.Classes
{
    public class Anaconda : Boas
    {
        //Properties
        public override string Name { get; set; }
        public override string Size { get; set; }

        //Constructor
        public Anaconda()
        {
            Name = "Anaconda";
            Size = "10 - 29 feet";
        }
    }
}
