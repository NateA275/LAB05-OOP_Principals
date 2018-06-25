using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_A_Zoo.Classes
{
    public abstract class Vertibrates
    {
        //Properties
        public abstract string Name { get; set; }
        public bool HasBackBone { get; set; }
        public virtual bool Nocturnal { get; set; }
        public abstract string Metabolism { get; set; }
        public abstract string Size { get; set; }
        public abstract bool LiveBirth { get; set; }
        public virtual string SkinCovering { get; set; }

        //Constructor
        public Vertibrates()
        {
            HasBackBone = true;
            Nocturnal = false;
        }

        //Methods
        public virtual string FamilyUnit()
        {
            return $"The {Name} is a solitary creature.";
        }

        public abstract string Diet();

        public abstract string Biome();
    }
}
