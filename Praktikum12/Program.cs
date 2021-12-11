using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum12
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("1. My scroll list\n2. Add scroll\nChoose what to do: ");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                Console.Clear();
                Console.WriteLine("Scroll to learn list:");
                List<string> scrolls = new List<string>() { "Book of Peace", "Scroll of Swords", "Silence Guide Book" };
                scrolls.InsertRange(2, new string[] {"book 3","book 4"});
                for (int i = 0; i < 5; i++)
                {
                    foreach (string scroll in scrolls)
                    {
                        Console.WriteLine($"Scroll {i + 1}: " + scroll);
                    }
                }
                Console.ReadKey();
                return;
            }
            if (input == 2)
            {
                Console.Clear();
                int[] scroll = new int[10];
                int[] queue = new int[10];
                for (int i = 0; i < 1; i++)
                {
                    Console.WriteLine("How many scroll to add:");
                    scroll[i] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("In what number of queue?");
                    queue[i] = Convert.ToInt32(Console.ReadLine());
                    string[] name = new string[10];
                    for (i = 0; i < 2; i++)
                    {
                        Console.WriteLine($"Scroll {i + 1} name: ");
                        name[i] = Console.ReadLine();
                    }
                    return;
                }
            }
        }
    }
}