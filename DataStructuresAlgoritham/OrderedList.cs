using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgoritham
{
    internal class OrderedList
    {
        public void ReadTextFile(string filePath)
        {
            string list = File.ReadAllText(filePath);
            string[] words = list.Split(",");
            SortingList<int> sortingList = new SortingList<int>();
            foreach (var data in words)
            {
                int result = Convert.ToInt32(data);
                sortingList.AddNode(result);
            }
            Console.WriteLine("Before Sort");
            sortingList.DisplaySort();
            sortingList.SortOrderedList();
            Console.WriteLine("After Sort");
            sortingList.DisplaySort();
        }
    }
}
