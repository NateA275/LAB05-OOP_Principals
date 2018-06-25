using System;
using System.Collections.Generic;
using System.Text;
using I_Built_A_Zoo.Interfaces;

namespace I_Built_A_Zoo.Classes
{

    public abstract class Owls : Birds, IFly
    {
        //Properties
        public abstract string WingSpan { get; set; }
        public override bool Nocturnal { get; set; }

        //Constructor
        public Owls()
        {
            Nocturnal = true;
        }

        //Methods
        public override string Diet()
        {
            return $"The {Name} eats fish, reptiles, birds, and small mammals.";
        }

        public override string Biome()
        {
            return $"The {Name} can be found in many different habitats, such as deserts, forests, prairies and even the Arctic Tundra.";
        }

        public string CoveredEnclosure()
        {
            return $"This {Name} has a covered enclosure to keep is safe inside the Zoo.";
        }
    }
}
