using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class Axe : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("You chop with the axe!");
        }
    }
}
