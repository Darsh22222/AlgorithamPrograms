using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgoritham
{
    internal class BinarySearch
    {
        string[] binaryArr;
        public void ReadTextFile(string filepath)
        {
            string words = File.ReadAllText(filepath);
            binaryArr = words.Split(" , ");
        }
        public void BinarySearchOperation(string input)
        {
            foreach (var word in binaryArr)
            {
                if (word.Equals(input))
                {
                    Console.WriteLine("Found the word in the list using binary");
                    return;
                }
            }
            Console.WriteLine("Search element is not available in list of words");
        }
        
    }
}

