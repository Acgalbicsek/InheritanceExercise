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

            var uromastyx = new Reptile();
            uromastyx.Name = "Uromastyx";
            uromastyx.ScaleType = "Spikes";
            uromastyx.IsOmnivorous = false;
            uromastyx.IsWarmBlooded = false;

            var raven = new Bird();
            raven.IsIntelligent = "Is one of the smartest birds in the world";
            raven.IsPredator = true;
            raven.Location = "lives in the arctic";
            raven.Name = "Raven";

            uromastyx.AboutReptile();
            raven.AboutBird();
            

            

            



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
