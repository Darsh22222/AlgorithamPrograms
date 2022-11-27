using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgoritham
{
    internal class PrimeRange
    {
        public int PrimeNumber(int min, int max)
        {
            Console.Write("Pime Numbers between the given range " + min + " to " + max + " are :-" + "\n");
            for (int i = min; i <= max; i++)
            {
                if (i > 2)
                {
                    int temp = i;
                    bool isPrime = true;
                    for (int j = 2; j < temp; j++)
                    {
                        if (temp % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime == true)
                    {
                        Console.Write(i + " ");
                    }
                }
                else
                {
                    if (i == 2)
                        Console.Write(i + " ");
                }
            }
            return max;
        }
    }
}

