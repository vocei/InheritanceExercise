using System;
using System.ComponentModel.DataAnnotations;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            var eagle = new Bird();
                eagle.isAlive = true;
                eagle.animalName = "Bald Eagle";
                eagle.ChirpSound = "EEEEEEE";
                eagle.CanFly = true;
                eagle.BeakColor = "Yellow";
                eagle.WingColor = "Brown";
                eagle.hasPattern = true;
                eagle.LandSeaAir = "Air";
            


            var blackMamba = new Reptile();
            {
                blackMamba.Carnivore = true;
                blackMamba.Color = "Brown, Brass, But Rarely Black";
                blackMamba.Herbivore = false;
                blackMamba.ColdBlooded = false;
                blackMamba.animalName = "Black Mamba";
                blackMamba.isAlive = true;
                blackMamba.LandSeaAir = "Land";
                blackMamba.hasPattern = false;
            };
            var goAnimals = new Animal[] {eagle, blackMamba};
            foreach (var animal in goAnimals) 
            {
                Console.WriteLine($"This is a {animal.animalName}!");
                Console.WriteLine($"It is {animal.isAlive} that this animal is alive currently..");
                Console.WriteLine($"The animals name is a {animal.animalName}.");
                Console.WriteLine($"It is {animal.hasPattern} that this animal has a pattern.");
                Console.WriteLine($"It is also a/an {animal.LandSeaAir} animal.");
                Console.WriteLine($"\n");

            }
        }
    }
}
