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



            var opt3 = new int[] { 1, 6, 5, 4, 3, 2, 7 };
            var etalon3 = new int[] { 1, 3, 5, 4, 6, 2, 7 };
            SortLevel.InsertionSortStep(opt3, 3, 1); //just for fast debug

           
            Console.ReadLine();

        }

    }

}
