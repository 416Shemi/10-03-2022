using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arry = { 3, 12, 15, 2, 16 };
            Console.WriteLine(wov(arry));
            Console.ReadLine();
        }
        static int wov(int[] arry)
        {
            int min = arry[0];
            int max = arry[0];
            for (int i = 0; i < arry.Length; i++)
            {
                if (arry[i] < min)
                {
                    min = arry[i];
                }
                else if (max > arry[i])
                {
                    max = arry[i];
                }
                return max;
            }
        }
    }
}
