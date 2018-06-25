using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_A_Zoo.Classes
{
    public abstract class Boas : Reptiles
    {
        //Properties
        public override bool LiveBirth { get; set; }

        //Constructor
        public Boas()
        {
            LiveBirth = true;
        }

        //Methods
        public override string Diet()
        {
            return $"The {Name} mostly eats small to medium sized mammals and birds.";
        }

        public override string Biome()
        {
            return $"The {Name} prefers to live in tropical enviroments. While they are able to swim, they prefer to live on land.";
        }
    }
}
