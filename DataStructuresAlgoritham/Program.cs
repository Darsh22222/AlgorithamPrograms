using System.Text;

namespace DataStructuresAlgoritham
{
    internal class Program
    {
        const string FILE_PATH = @"C:\GetRepositry\AlgorithamPrograms\DataStructuresAlgoritham\BinarySearch.txt";
        static void Main(string[] args)
        {
            

            Console.WriteLine("Welcome to DataStructureAlgoritham");
            BinarySearch binary = new BinarySearch();
            bool condition = true;
            while (condition)
            {
                Console.WriteLine("1. Binary Search\n2. Insertion Sorting\n3. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the word you want to Search");
                        binary.ReadTextFile(FILE_PATH);
                        binary.BinarySearchOperation("Hello,Welcome,To,Coding.");
                        break;
                    case 2:
                        Console.WriteLine("\n");
                        int[] arr = { 2, 5, 7, 6, 1, 4 };
                        InsertionSort insertion = new InsertionSort();
                        insertion.Sort(arr);
                        break;
                    default:
                        Console.WriteLine("Try Again");
                        condition = false;
                        break;
                }
            }

        }
    }
}