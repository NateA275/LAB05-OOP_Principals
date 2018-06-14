using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_A_Zoo.Classes
{
    abstract class Vertibrates
    {
        public bool HasBackBone = true;

        public virtual bool Nocturnal()
        {
            return false;
        }

        public abstract string Metabolism();

        public abstract bool LiveBirth();

        public virtual string FamilyUnit()
        {
            return "Solitary";
        }

        public abstract string Diet();

        public abstract string Biome();
    }
}
