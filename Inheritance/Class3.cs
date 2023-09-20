using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
   public class Reptile : Animal
    {
        public Reptile() 
        {
        
        }

        public bool ColdBlooded { get; set; }
        public bool Herbivore { get; set; }
        public bool Carnivore { get; set; }
        public string Color { get; set; }
    }
}
