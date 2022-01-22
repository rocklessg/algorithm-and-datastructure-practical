using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeChallenge
{
    public class FibonacciSequence
    {
        public static void Fibonacci(int n)
        {
            int current = 0;
            int next = 0;

            for (int i = 0; i <= n; i++)
            {
                Console.Write(next + " ");

                if (next == 0)
                {
                    next += 1;
                }
                else
                {
                    int temp = next;
                    next += current;
                    current = temp;
                }
            }         
        }
    }
}
