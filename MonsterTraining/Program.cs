using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            Monster Player1 = new Monster();

            bool quit = false;
            while(!quit)
            {
                //Menu
                //Todo: Use enums to clarify the switch statement
                string message = "Welcome to the world of Monster Training!\n";
                string[] mainMenu = { "Create Monster", "Attack Monster", "Quit" };
                int mainMenuChoice = UIUpdate.Menu(message, mainMenu);

                switch (mainMenuChoice)
                {
                    case 1:
                        Player1 = CreatePlayer1();
                        break;
                    case 2:
                        DealDamage(10, Player1);
                        break;
                    case 3:
                        quit = true;
                        break;
                    default:
                        UIUpdate.Message("That wasn't an option.");
                        break;
                }
                mainMenuChoice = 0;
            }
        }

        //Todo: Use polymorphism to make this work for multiple players
        private static void DealDamage(int damage, Monster Player1)
        {
            Player1.GetHP();
            Player1.TakeDamage(damage);
            Player1.GetHP();
        }

        private static Monster CreatePlayer1()
        {
            Monster Player1;
            UIUpdate.Message("What's the monsters name?");
            string name = Console.ReadLine();
            Player1 = new Monster(name);
            return Player1;
        }
    }
}
