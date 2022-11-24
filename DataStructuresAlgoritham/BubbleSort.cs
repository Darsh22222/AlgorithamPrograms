using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgoritham
{
    public class BubbleSort
    {
        public void Bubble(int[] binaryArr)
        {
            for (int i = 0; i < binaryArr.Length - 1; i++) // traversing 5 time
            {
                for (int j = 0; j < binaryArr.Length - 1; j++)
                {
                    if (binaryArr[j] > (binaryArr[j + 1])) 
                    {
                        int temp = binaryArr[j + 1];
                        binaryArr[j + 1] = binaryArr[j];
                        binaryArr[j] = temp;
                    }
                }
            }
            foreach (var data in binaryArr)
            {
                Console.WriteLine(data);
            }
        }
    }
}
