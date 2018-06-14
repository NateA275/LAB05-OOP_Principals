using System;
using System.Collections.Generic;
using System.Text;
using I_Built_A_Zoo.Interfaces;

namespace I_Built_A_Zoo.Classes
{
    abstract class Dolphin : Mammals, ISwim
    {
        public override string SkinCovering()
        {
            return "none";
        }

        public override string FamilyUnit()
        {
            return "A family of Dolphins is called a 'pod'";
        }
        public override string Biome()
        {
            return "Dolphins inhabit all of the oceans of the planet and even some rivers.";
        }

        public override string Diet()
        {
            return "Dolphins mostly eat fish. Some also eat squid, and larger Dolphins, like Orcas, eat seals and sea lions.";
        }

        public abstract string Salinity();

        public abstract int WaterTemp();
    }
}
