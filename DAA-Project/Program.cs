using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DAA_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashing h = new Hashing();
            OpenHashing oh = new OpenHashing();
            CloseHashing ch = new CloseHashing();
            char anotherKey;

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(h.caseSelectionMsg);

            string userSelectCase = Console.ReadLine();
            if (!h.stringIsNullOrEmpty(userSelectCase))
            {
                char choice = Convert.ToChar(userSelectCase);
                Console.Clear();
                switch (choice)
                {
                    case '1':
                          oh.setHashMapLength();
                          oh.initializeOpenHashMap();
                 
                          do
                          {
                              Console.ForegroundColor = ConsoleColor.DarkCyan;
                              Dictionary<string, int> ohKeyIndex = oh.hashFunction();
                              oh.addToOpenHashMap(ohKeyIndex);
                              foreach (var item in ohKeyIndex)
                              {
                                  Console.WriteLine("Your Key is : {0} & Index on Open HashMap : {1}", item.Key, item.Value);
                              }
                              Console.ForegroundColor = ConsoleColor.Green;
                              Console.WriteLine(h.enterAnotherKeyMsg);
                              anotherKey = Convert.ToChar(Console.ReadLine());
                              Console.ForegroundColor = ConsoleColor.White;

                          } while (anotherKey == 'y');
                          oh.printOpenHashMap();

                          Console.ReadLine();
                        break;
                    case '2':
                        ch.setHashMapLength();
                        ch.initializeCloseHashMap();
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Dictionary<string, int> chkeyIndex = ch.hashFunction();
                            ch.addToCloseHashMap(chkeyIndex);
                            foreach (var item in chkeyIndex)
                            {
                                Console.WriteLine("Sum of hash Index Values : {0} {1}", item.Key, item.Value);
                            }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(h.enterAnotherKeyMsg);
                            anotherKey = Convert.ToChar(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.White;

                        } while (anotherKey == 'y');
                        ch.printCloseHashMap();

                        Console.ReadLine();
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(h.errMsg);
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                        break;
                }
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(h.errMsg);
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
            
        }
    }
}
