using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            var Chicken = new Bird();
            Chicken.LifeExpectancy = 15;
            Chicken.HasHeart = true;
            Chicken.EatsFood = true;
            Chicken.DrinksWater = true;
            Chicken.CanRunFast = true;
            Chicken.Vegetarian = false;
            Chicken.BuildsNest = true;
            Chicken.HasWings = true;

            var Uromastyx = new Reptile();
            Uromastyx.LifeExpectancy = 25;
            Uromastyx.HasHeart = true;
            Uromastyx.EatsFood = true;
            Uromastyx.DrinksWater = true;
            Uromastyx.Vegetarian=true;
            Uromastyx.ColdBlooded = true;
            Uromastyx.LaysEggs = true;
            Uromastyx.LifeExpectancy = 25;
            Uromastyx.HasScales = true;

            string userInput;


            Console.WriteLine($"Would you like to read about chickens?");
            userInput = Console.ReadLine();

            if (userInput == "no")
            {
                Console.WriteLine($"Really?  That is sad, because chickens are amazing!");
            }
            if (userInput == "yes")
            {
                Console.WriteLine($"Great!  Chickens can live to be {Chicken.LifeExpectancy} years old.  It's {Chicken.CanRunFast} that chickens can run fast- up to 10 MPH! " +
                   $"Most people think chickens are vegetarian, but that is {Chicken.Vegetarian}.  They are omnivores, and will kill and eat rodents.  It's {Chicken.BuildsNest} that " +
                   $"chickens will build nests, and they also share nests.  Hens take turns sitting on eggs.  Although it is {Chicken.HasWings} that chickens have wings, they don't really fly- " +
                   $"when they jump, they just catch air, and fall gracefully, because they are too heavy. ");
            }


            Console.WriteLine($"Are you ready to learn about a small lizard known as a Uromastyx?");
            userInput = Console.ReadLine();

            if(userInput == "no")
            {
                Console.WriteLine($"Okay, you are missing out on a great opportunity to learn.");
            }
            if(userInput == "yes")
            {
                Console.WriteLine($"Uromastyx are vegetarians- {Uromastyx.Vegetarian}.  They have scales-{Uromastyx.HasScales}.  They lay eggs- {Uromastyx.LaysEggs}: the female buries" +
                    $" her eggs in a warm burrow, and stays with the eggs until they hatch. Uromastyx are cold-blooded lizards- {Uromastyx.ColdBlooded}. They can live to be {Uromastyx.LifeExpectancy}" +
                    $" years old!");
            }








            // TODO Be sure to follow best practice when creating your classes

            //DONE Create a class Animal
            //DONE give this class 4 members that all Animals have in common


            //DONE Create a class Bird
            // DONE give this class 4 members that are specific to Bird
            // DONE Set this class to inherit from your Animal Class

            // DONE Create a class Reptile
            // DONE give this class 4 members that are specific to Reptile
            // Done Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }


    }
}
