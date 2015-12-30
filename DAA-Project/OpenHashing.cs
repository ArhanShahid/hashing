using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAA_Project
{
    class OpenHashing : Hashing
    {
        
        public LinkedList<string>[] openHashMap;

        public void initializeOpenHashMap()
        {
            openHashMap = new LinkedList<string>[HashMapLength];
            for (int i = 0; i < openHashMap.Length; i++)
            {
                openHashMap[i] = new LinkedList<string>();
            }
        }


        public void addToOpenHashMap(Dictionary<string, int> ohKeyIndex)
        {
            foreach (var item in ohKeyIndex)
            {
                openHashMap[item.Value].AddFirst(item.Key);
            }
        }

        public void printOpenHashMap()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int i = 0;
            foreach (var Llist in openHashMap)
            {
                Console.Write("Index {0} Values : ", i);
                foreach (var item in Llist)
                {
                    Console.Write("{0} , ",item);
                }
                i++;
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
