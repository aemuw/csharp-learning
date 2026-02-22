using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            int[] myArray = new int[5] { 5, -1, 0, 4, 6 };
            int[] arr = new int[] { 23, -1 };

            //int[] errorArray = new int[];
            //або одразу проініціалізувати елементи масиву {1}
            //або ввести кількість елементів []

            int[] ogoArray = new[] { 1, 5, 0 };
            int[] OGOArray = { 4, -8, 3 };
            //int[] neProkatytArray = new [5];

            int[] myArr = Enumerable.Repeat(5, 10).ToArray();
            //5 - значення елемента10 - кількість елементів масиву

            int[] myRangeArr = Enumerable.Range(4, 5).ToArray();
            //в масиві 5 елементів, їх значення - починаючи з 4 (4, 5, 6, 7, 8)
        }
    }
}
