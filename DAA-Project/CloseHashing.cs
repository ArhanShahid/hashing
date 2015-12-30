using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DAA_Project
{
    class CloseHashing : Hashing
    {
        public string[] closeHashMap;

        public void initializeCloseHashMap()
        {
            closeHashMap = new string[HashMapLength];
            
        }
        public void addToCloseHashMap(Dictionary<string, int> chKeyIndex)
        {
            int Index = 0;
            string value = null;
            bool IsHighIndexEmpty = true;
            bool IsLowIndexEmpty = true;
            bool IsCloseHashMapFull = true;
            foreach (var item in chKeyIndex)
            {
                Index = item.Value;
                value = item.Key;  
            }
            Console.WriteLine("Index : {0} Value : {1}", Index, value);
            for (int i = 0; i < closeHashMap.Length; i++)
            {
              if (stringIsNullOrEmpty(closeHashMap[Index]))
                {
                   
                    closeHashMap[Index] = value;
                    IsHighIndexEmpty = false;
                    IsLowIndexEmpty = false;
                    IsCloseHashMapFull = false;
                    break;
                }
            }

            if (IsHighIndexEmpty)
            {
                for (int i = Index; i < closeHashMap.Length; i++)
                {
                    if (stringIsNullOrEmpty(closeHashMap[i]))
                    {
                        closeHashMap[i] = value;
                        IsLowIndexEmpty = false;
                        IsCloseHashMapFull = false;
                        break;
                    }  
                }         
            }
            if (IsLowIndexEmpty)
            {
                for (int i = 0; i < Index; i++)
                {
                    if (stringIsNullOrEmpty(closeHashMap[i]))
                    {
                        closeHashMap[i] = value;
                        IsCloseHashMapFull = false;
                        break;
                    }
                }       
                
            }

            if (IsCloseHashMapFull)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Close HashMap is Now Full");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(2000);
                Environment.Exit(0);
            }


        }
        public void printCloseHashMap()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int i = 0;
            foreach (var item in closeHashMap)
            {
                Console.Write("Index {0} Value : {1}", i, item);
                i++;
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
       
    }
}
