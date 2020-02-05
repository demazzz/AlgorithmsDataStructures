using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using AlgorithmsDataStructures2;
using SortSpace;



namespace AlgorithmsDataStructures
{
    public class Program
    {
        static void Main(string[] args)
        {



            var opt = new int[] {10, 7, 5, 6, 9, 4, 3, 1, 2,8 };

            //int iii = SortLevel.ArrayChunk(opt);

            int[] arr = { 3, 9, 4, 6,5, 1, 2, 8, 10, 7 };

            Console.WriteLine("Unsorted");
            foreach (int n in arr)
                Console.Write(n + " ");
            Console.WriteLine();

            SortLevel.QuickSort(arr);
            Console.WriteLine("Unsorted");
            foreach (int n in arr)
                Console.Write(n + " ");
            Console.WriteLine();

            Console.ReadLine();

        }

    }

}
