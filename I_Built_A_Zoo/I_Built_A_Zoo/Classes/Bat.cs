using System;
using System.Collections.Generic;
using System.Text;
using I_Built_A_Zoo.Interfaces;

namespace I_Built_A_Zoo.Classes
{
    abstract class Bat : Mammals, IFly
    {
        public override bool Nocturnal()
        {
            return true;
        }

        public override string FamilyUnit()
        {
            return "A family of bats is called a 'colony'.";
        }

        public override string Biome()
        {
            return "Bats are found on every continent except polar regions and extreme deserts.";
        }

        public string CoveredEnclosure()
        {
            return "The zoo does have a covered enclosure for our bat exhibit. Check.";
        }

        public abstract string WingSpan();
    }
}
