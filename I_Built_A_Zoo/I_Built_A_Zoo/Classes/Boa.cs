using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_A_Zoo.Classes
{
    abstract class Boa : Reptiles
    {
        public override string Biome()
        {
            return "Boas prefer to live in tropical enviroments, such as in South America. While they can swim, they prefer to live on land.";
        }

        public override string Diet()
        {
            return "Small to medium sized mammals and birds.";
        }

        public override bool LiveBirth()
        {
            return true;
        }
    }
}
