using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance

// Create a class Reptile
// give this class 4 members that are specific to Reptile
// Set this class to inherit from your Animal Class

{
    internal class Reptile : Animal
    {
        public bool IsWarmBlooded { get; set; }
        public bool IsOmnivorous { get; set; }

        public string Name { get; set; }

        public string ScaleType { get; set; }

        public void AboutReptile()
        {
            Console.WriteLine($"The {Name} is a cute small reptile with {ScaleType}.  Do you think the {Name} is warm blooded?");
            Console.ReadLine();
            Console.WriteLine($"The answer is {IsWarmBlooded}.  Do you think the {Name} is omnivorous?");
            Console.ReadLine();
            Console.WriteLine($"Tje amswer is {IsOmnivorous}.  Bye!");
        }
    }
}
