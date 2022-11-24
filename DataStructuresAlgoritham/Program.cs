using System.Text;

namespace DataStructuresAlgoritham
{
    internal class Program
    {
        const string FILE_PATH = @"C:\GetRepositry\AlgorithamPrograms\DataStructuresAlgoritham\BinarySearch.txt";
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to DataStructureAlgoritham");
            BinarySearch binarySearch = new BinarySearch();
            binarySearch.ReadTextFile(FILE_PATH);
            binarySearch.BinarySearchOperation("Hello, Welcome, To, Coding.");


        }
    }
}