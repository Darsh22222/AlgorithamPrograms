using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgoritham
{
    internal class BalancedParanthesis
    {
        public void ReadTextFile(string filePath)
        {
            string list = File.ReadAllText(filePath);
            string[] words = list.Split(" ");
            Stack<string> stack = new Stack<string>();
            foreach (var data in words)
            {
                if (data.Equals("("))
                    stack.Push(data);
                if (data.Equals(")"))
                    stack.Pop();
            }
            if (stack.Peek())
            {
                Console.WriteLine("Balanced Parantheses");
            }
            else
            {
                Console.WriteLine("Unbalanced Paranthese");
            }
        }
    }
}
