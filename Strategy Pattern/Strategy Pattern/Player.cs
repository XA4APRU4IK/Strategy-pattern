using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class Player
    {
        private IWeapon weapon;

        public Player(IWeapon startingWeapon)
        {
            weapon = startingWeapon;
        }

        public void SetWeapon(IWeapon newWeapon)
        {
            weapon = newWeapon;
        }

        public void Attack()
        {
            weapon.UseWeapon();
        }
    }
}
