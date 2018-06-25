using System;
using System.Collections.Generic;
using System.Text;
using I_Built_A_Zoo.Interfaces;

namespace I_Built_A_Zoo.Classes
{
    public abstract class Bats : Mammals, IFly
    {
        //Properties
        public override bool Nocturnal { get; set; }
        public abstract string WingSpan { get; set; }

        //Constructor
        public Bats()
        {
            Nocturnal = true;
        }

        //Methods
        public override string FamilyUnit()
        {
            return $"The {Name} has a family unit called a 'colony'.";
        }

        public override string Biome()
        {
            return $"The {Name} can be found on every continent except polar regions and extreme deserts.";
        }

        public string CoveredEnclosure()
        {
            return $"This {Name} has a covered enclosure to keep is safe inside the Zoo.";
        }
    }
}
