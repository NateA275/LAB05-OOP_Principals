using System;
using I_Built_A_Zoo.Classes;
using I_Built_A_Zoo.Interfaces;

namespace I_Built_A_Zoo
{
    class Program
    {
        static void Main(string[] args)
        {

            Vertibrates[] myZoo = new Vertibrates[] { new FruitBat(), new Bottlenose(), new Striped(),
                                                      new American(), new Chinese(), new Constrictor(),
                                                      new Anaconda(), new Common(), new Emporer(),
                                                      new King(), new Screech(), new Snowy()};

            foreach (Vertibrates animal in myZoo)
            {
                Console.Clear();
                Console.WriteLine($"--Some Facts About the {animal.Name}!--");
                Console.WriteLine($"-{animal.Size}.");
                if (animal is IFly)
                    Console.WriteLine($"-Loves to fly!");
                if (animal is ISwim)
                    Console.WriteLine($"-Loves to swim!");
                Console.WriteLine(animal.Nocturnal ? "-Is active at night." : "-Is most active during the day.");
                Console.WriteLine($"-Is {animal.Metabolism}.");
                Console.WriteLine(animal.LiveBirth ? "-Gives birth to live offspring." : "-Lays eggs.");
                if (animal.SkinCovering == "none")
                    Console.WriteLine($"-Unline most mammals, the {animal.Name} does not have fur!");
                else
                    Console.WriteLine($"-Covered with {animal.SkinCovering}.");
                Console.WriteLine($"-{animal.FamilyUnit()}");
                Console.WriteLine($"-{animal.Diet()}");
                Console.WriteLine($"-{animal.Biome()}");
                Console.WriteLine("\nPress ENTER to continue!");
                Console.ReadLine();
            } 
        }

    }
}
