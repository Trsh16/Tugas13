using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas13
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
                Console.Write("1. My scroll list\n2. Add scroll\n3. Search scroll\n4. Remove scroll\nChoose what to do : ");
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
                else if (input == 3)
                {
                    Console.Clear();
                    for (int i = 0; i < 1; i++)
                    {
                        Console.WriteLine("Insert scroll name:");
                        var cari = Console.ReadLine();
                        if (scrolls.Contains(cari, StringComparer.OrdinalIgnoreCase))
                        {
                            Console.WriteLine($"Book found. Queue number: {scrolls[i]}");
                        }
                        else
                        {
                            Console.WriteLine("Book not found");
                        }
                    }
                }
                else if (input == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Remove from list by scroll name? Y/N:");
                    { 
                    
                        var remove = Console.ReadLine().Trim();
                        {
                            if (remove == "y" || remove == "Y")
                            {
                                Console.WriteLine("Input scroll name:");
                                var book = Console.ReadLine().Trim();
                                
                                if (scrolls.Contains(book, StringComparer.OrdinalIgnoreCase))
                                {
                                    scrolls.Remove(book);

                                    Console.WriteLine("Book Removed!");
                                }
                                else
                                {
                                    Console.WriteLine("Book not found");
                                }
                            }
                            else if (remove == "n" || remove == "N")
                            {
                                Console.WriteLine("Input scroll queue:");
                                var bookqueue = Console.ReadLine();
                                if (scrolls.Contains(bookqueue, StringComparer.CurrentCultureIgnoreCase))
                                {
                                    scrolls.Remove(bookqueue);
                                    Console.WriteLine("Book Removed!");
                                }
                                else
                                {
                                    Console.WriteLine("Queue not found. insert scroll queue:");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Wrong selection. Choose again:");
                            }
                        }
                    }
                }
            }
        }
    }
}
    

