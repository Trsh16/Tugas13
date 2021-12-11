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
            var input = 0;
            var counter = 0;
            var scroll = 0;
            var queue = 0;
            List<string> baru = new List<string>();
            List<string> scrolls = new List<string>() { "Book of Peace", "Scroll of Swords", "Silence Guide Book" };
            while (true)
            {
                Console.Write("1. My scroll list\n2. Add scroll\nChoose what to do : ");
                input = Convert.ToInt32(Console.ReadLine());
                if (input == 1)
                {
                    Console.Clear();
                    counter = 0;
                    Console.WriteLine("Scroll to learn list : ");
                    for (int i = 0; i < scrolls.Count(); i++)
                    {
                        Console.WriteLine($"Scroll {i + 1}: {scrolls[i]}");
                    }
                }
                else if (input == 2)
                {
                    Console.Clear();
                    for (int i = 0; i < 1; i++)
                    {
                        Console.WriteLine("How many scroll to add:");
                        scroll = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("In what number of queue?");
                        queue = Convert.ToInt32(Console.ReadLine());
                        for (i = 0; i < scroll; i++)
                        {
                            Console.WriteLine($"Scroll {i + 1} name: ");
                            baru.Add(Console.ReadLine());
                        }
                        if (queue > scrolls.Count())
                        {
                            queue = scrolls.Count();
                        }
                        foreach (var scrool in baru)
                        {
                            scrolls.Insert(queue + counter - 1, scrool);
                            counter++;
                        }
                        baru.Clear();
                    } 
                }
            }
        }
    }
}