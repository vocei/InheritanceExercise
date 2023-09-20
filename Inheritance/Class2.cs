using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird() 
        {
        
        }
        public string WingColor { get; set; }
        public string BeakColor { get; set;}
        public bool CanFly { get; set; }
        public string ChirpSound { get; set; }
    }
}
