using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterTraining
{
    public class UIUpdate
    {
        public static void Message(string message)
        {
            Console.WriteLine(message);
        }

        public static void Message(int message)
        {
            Console.WriteLine(message);
        }

        public static void Message(float message)
        {
            Console.WriteLine(message);
        }

        public static void Message(bool message)
        {
            Console.WriteLine(message);
        }

        public static int Menu(string message, string[] items)
        {
            Console.WriteLine(message);

            int i = 1;
            foreach (string item in items)
            {
                Console.WriteLine("{0}) {1}", i, item);
                i++;
            }

            Console.Write("\nChoose a number from the list:");
            int choice = Convert.ToInt32(Console.ReadLine());

            return choice;
        }
    }
}
