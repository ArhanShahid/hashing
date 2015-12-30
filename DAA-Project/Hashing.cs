using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DAA_Project
{
    public class Hashing
    {
        public int HashMapLength;
        public string errMsg = "Invalid of Empty Input";
        public string caseSelectionMsg = "Open Hashing: Press 1\nClose Hashing Press 2\nEnter Your Choice : ";
        public string HashMapLengthMsg = "Enter Hash Map Length : ";
        public string enterKeyMsg = "Enter Your Key : ";
        public string enterAnotherKeyMsg = "Do you want to add another Key?\nPress y\nPress n";
        Dictionary<char, int> characterValues = new Dictionary<char, int>()
	    {
	        {'a', 1},
	        {'b', 2},
	        {'c', 3},
	        {'d', 4},
            {'e', 5},
            {'f', 6},
            {'g', 7},
            {'h', 8},
            {'i', 9},
            {'j', 10},
            {'k', 11},
            {'l', 12},
            {'m', 13},
            {'n', 14},
            {'o', 15},
            {'p', 16},
            {'q', 17},
            {'r', 18},
            {'s', 19},
            {'t', 20},
            {'u', 21},
            {'v', 22},
            {'w', 23},
            {'x', 24},
            {'y', 25},
            {'z', 26},
            {'A', 1},
	        {'B', 2},
	        {'C', 3},
	        {'D', 4},
            {'E', 5},
            {'F', 6},
            {'G', 7},
            {'H', 8},
            {'I', 9},
            {'J', 10},
            {'K', 11},
            {'L', 12},
            {'M', 13},
            {'N', 14},
            {'O', 15},
            {'P', 16},
            {'Q', 17},
            {'R', 18},
            {'S', 19},
            {'T', 20},
            {'U', 21},
            {'V', 22},
            {'W', 23},
            {'X', 24},
            {'Y', 25},
            {'Z', 26}
	    };

        public bool stringIsNullOrEmpty(string s)
        {
            if (String.IsNullOrEmpty(s))
                return true;
            else
                return false;
        }
        public void setHashMapLength()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(HashMapLengthMsg);
                int length = Convert.ToInt32(Console.ReadLine());
                HashMapLength = length;
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(errMsg);
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(2000);
                Environment.Exit(0);
            }

           
        }

        private int keySum(char[] keyArray)
        {
            int sum = 0;
            for (int i = 0; i < keyArray.Length; i++)
            {
                if (characterValues.ContainsKey(keyArray[i]))
                {
                    sum += characterValues[keyArray[i]];
                }
            }
          return sum;
        }
        private int hashLocation(int sum)
        {
            return sum % HashMapLength;
        }

        public  Dictionary<string, int> hashFunction()
        {
            Dictionary<string, int> keyIndex = new Dictionary<string, int>();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(enterKeyMsg);
            string key = Console.ReadLine();
            char[] keyArray = key.ToCharArray();
            int sumOfCharacterValues = keySum(keyArray);
            int hashIndex = hashLocation(sumOfCharacterValues);

            keyIndex.Add(key,hashIndex);
            Console.ForegroundColor = ConsoleColor.White;

            return keyIndex;
        }
    }
}
