using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var birdOne = new Bird();
            birdOne.age = 7;
            birdOne.Carnivore = true;
            birdOne.Type = "Pelican";
            birdOne.legs = 2;
            birdOne.Color = "Brown";
            birdOne.CanFly = true;
            birdOne.Weight = 25;
            birdOne.ClimateOrigin = "Southeast";


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var alligator = new Reptile();
            alligator.age = 12;
            alligator.Type = "Alligator";
            alligator.Weight = 700;
            alligator.IsColdBlooded = true;
            alligator.IsScaly = true;
            alligator.legs = 4;
            alligator.CanSwim = true;
            alligator.Habitat = "Swamp";


            var myPets = new Animal[] { birdOne, alligator };
            foreach(var Animal in myPets)
            {
                Console.WriteLine($"Pet species is: {Animal.Type}" );
                Console.WriteLine($"{Animal.Type} has {Animal.legs} many legs!");
                Console.WriteLine($"{Animal.Type} is {Animal.age} years old.");
                Console.WriteLine($"{Animal.Type} weighs {Animal.Weight} pounds.");
                Console.WriteLine("");
            }


        }
    }
}
