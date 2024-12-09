using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class Game
    {
        private Player player;

        public Game()
        {
            player = new Player(new Sword()); // Начальное оружие - меч
        }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("Choose an action: (1) Attack (2) Change Weapon (3) Exit");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        player.Attack();
                        break;
                    case "2":
                        ChangeWeapon();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        private void ChangeWeapon()
        {
            Console.WriteLine("Choose a weapon: (1) Sword (2) Bow (3) Axe");
            var weaponChoice = Console.ReadLine();

            switch (weaponChoice)
            {
                case "1":
                    player.SetWeapon(new Sword());
                    break;
                case "2":
                    player.SetWeapon(new Bow());
                    break;
                case "3":
                    player.SetWeapon(new Axe());
                    break;
                default:
                    Console.WriteLine("Invalid weapon choice. Try again.");
                    break;
            }

            Console.WriteLine("Weapon changed successfully!");
        }
    }+
}
