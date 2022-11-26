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
                Console.WriteLine("1. Binary Search\n2. Insertion Sorting\n3.Bubble Sort Algorithm\n4.Anagram" +
                    "\n5.Replace String Using Regex \n6.Ordered List\n7.unorderd List\n8.Balanced Paranthesis\n9. Exit");
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
                    case 3:
                        Console.WriteLine("\n");
                        int[] arr1 = { 8, 3, 5, 8, 8, 1, 4, 3, 9, 2 };
                        BubbleSort bubbleSort = new BubbleSort();
                        bubbleSort.Bubble(arr1);
                        Console.WriteLine("\n");
                        break;
                    case 4:
                        Anagram anagram = new Anagram();
                        anagram.CheckAnagram("heart", "earth");
                        break;
                    case 5:
                        StringReplace stringReplace = new StringReplace();
                        stringReplace.Validate("\nHello << name >>, We have your fullname as << full name >> in our system.", "Darshan");
                        stringReplace.ValidateNumber("your contact number is << contactno >>.", "8329711253");
                        stringReplace.ValidateDate("Thank you BridgeLabz << Date >>.\n", "10/10/2022");
                        break;
                    case 6:
                        OrderedList orderedList = new OrderedList();
                        orderedList.ReadTextFile(@"C:\GetRepositry\AlgorithamPrograms\DataStructuresAlgoritham\Files\SortingList.txt");
                        Console.WriteLine("\n");
                        break;
                    case 7:
                        UnorderedList<string> unordered = new UnorderedList<string>();
                        unordered.Add("Add");
                        unordered.Add("Sub");
                        Console.WriteLine("Add & Sub are Successfully Added.");
                        unordered.Display();
                        Console.WriteLine("Sub is going to Delete");
                        unordered.Delete();
                        unordered.Display();
                        break;
                    case 8:
                        BalancedParanthesis balance = new BalancedParanthesis();
                        balance.ReadTextFile(@"C:\GetRepositry\AlgorithamPrograms\DataStructuresAlgoritham\Files\BalancedParanthesis.txt");
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