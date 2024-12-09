using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class Bow : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("You shoot an arrow from the bow!");
        }
    }
}
