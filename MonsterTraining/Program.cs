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
            Monster Player1 = new Monster("Tom");
            Monster Player2 = new Monster("Dick");

            /*I have more to learn before I can dynamically create monsters.*/

            //List<Monster> monsterz = new List<Monster>();
            //Dictionary<string, Type> monsters = new Dictionary<string, Type>();
            //int pos = monsters.Count;
            //monsters.Add("Player"+Convert.ToString(pos+1)) = typeof(Monster);

            //monsters.Add()

            Console.Clear();
            bool quit = false;
            while(!quit)
            {
                //Menu
                string message = "\nChoose an option from the menu below:\n";
                string[] mainMenu = { "Create Monster", "Attack Monster", "Quit" };
                int mainMenuChoice = UIUpdate.Menu(message, mainMenu);


                switch (mainMenuChoice)
                {
                    case (int)EnumMenu.CreateMonster:
                        message = "\nChoose which player to edit";
                        string[] createMenu = { "Player 1", "Player 2", "Cancel"};
                        int playerNum = UIUpdate.Menu(message, createMenu);
                       
                        switch (playerNum)
                        {
                            case 1:
                                Player1 = CreatePlayer();
                                break;
                            case 2:
                                Player2 = CreatePlayer();
                                break;
                            case 3:
                                break;
                            default:
                                UIUpdate.Message("\nInvalid Selection\n\n");
                                break;
                        }
                        break;

                    case (int)EnumMenu.AttackMonster:
                        DealDamage(10, Player1);
                        break;
                    case (int)EnumMenu.Quit:
                        quit = true;
                        break;
                    default:
                        UIUpdate.Message("\nThat wasn't an option.\n\n");
                        break;
                }
                mainMenuChoice = 0;
            }
            Console.WriteLine("\n\nThank you for using MonsterTrainer");
        }

        //Todo: Use polymorphism to make this work for multiple players
        private static void DealDamage(int damage, Monster Player1)
        {
            Player1.GetHP();
            Player1.TakeDamage(damage);
            Player1.GetHP();
        }

        private static Monster CreatePlayer()
        {
            UIUpdate.Message("\nWhat's the monsters name?");
            string name = Console.ReadLine();
            return new Monster(name);
        }
    }
}
