using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingExtensions;

namespace AlgoTester
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> fred = new List<int>(new int[]{-2, 34, 1, 3, 532, 1, 152, 2, 3, 52, 1, 152, 2, 22, 23, 44, 11 });
            int[] fred = new int[] { -2, 34, 1, 3, 532, 1, 152, 2, 3, 52, 1, 152, 2, 22, 23, 44, 11 };
            List<int> sorted = fred.ToList();
            System.Console.WriteLine("[{0}]", string.Join(", ", fred.InsertionSort()));
            sorted.Sort();
            System.Console.WriteLine("[{0}]", string.Join(", ", sorted));
        }
    }
}
