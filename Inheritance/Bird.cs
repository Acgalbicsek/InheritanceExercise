using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public bool Vegetarian { get; set; }
        public bool CanRunFast { get; set; }    
        public bool BuildsNest { get; set; }
        public bool HasWings { get; set; }
    }
}
