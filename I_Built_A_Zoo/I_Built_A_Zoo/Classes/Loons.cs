using System;
using System.Collections.Generic;
using System.Text;
using I_Built_A_Zoo.Interfaces;

namespace I_Built_A_Zoo.Classes
{
    public abstract class Loons : Birds, ISwim, IFly
    {
        //Properties
        public int WaterTemp { get; set; }
        public string Salinity { get; set; }
        public abstract string WingSpan { get; set; }

        //Constructor
        public Loons()
        {
            WaterTemp = 50;
            Salinity = "fresh water";
        }

        //Methods
        public override string FamilyUnit()
        {
            return $"The family unit of the {Name} is called an 'Asylum'.";
        }

        public override string Diet()
        {
            return $"The {Name} mainly eats fish - supplemented by amphibians, crustaceans, and similar sized aquatic fauna.";
        }

        public override string Biome()
        {
            return $"The {Name} inhabits the {Salinity} Lakes of northern Michigan, Wisconsin, and Minesota.";
        }

        public string CoveredEnclosure()
        {
            return $"This {Name} has a covered enclosure to keep is safe inside the Zoo.";
        }
    }
}
