using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{// Create a class Bird
 // give this class 4 members that are specific to Bird
 // Set this class to inherit from your Animal Class
    internal class Bird : Animal
    {
        public string IsIntelligent{ get; set; }
        public bool IsPredator { get; set; }
        public string Name { get; set; }

        public string Location { get; set; }

       public void AboutBird()
        {
            Console.WriteLine($"The {Name} is a large black bird with a heavy bill. The {Name} {IsIntelligent}, and {Location}.  Do you think the {Name} is a predatory bird?");
            Console.ReadLine();
            Console.WriteLine($"The answer is {IsPredator}.  Bye!");
        }
    }
}
