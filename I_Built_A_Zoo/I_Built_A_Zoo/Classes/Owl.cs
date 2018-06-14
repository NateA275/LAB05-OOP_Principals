using System;
using System.Collections.Generic;
using System.Text;
using I_Built_A_Zoo.Interfaces;

namespace I_Built_A_Zoo.Classes
{

    abstract class Owl : Birds, IFly
    {
        public override string Diet()
        {
            return "Owls eat fish, reptiles, birds, and small mammals.";
        }

        public override string Biome()
        {
            return "Owls can be found in many different habitats, such as deserts, forets, prairies and even the Arctic Tundra.";
        }

        public string CoveredEnclosure()
        {
            return "The zoo does have a covered enclosure for our owl exhibit. Check.";
        }

        public abstract string WingSpan();

    }
}
