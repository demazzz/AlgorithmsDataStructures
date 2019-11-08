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



            var opt3 = new int[] { 6, 3, 5, 4, 1, 2, 7,9,8,10,0,11,12 };
            var etalon3 = new int[] { 1, 3, 5, 4, 6, 2, 7 };
            SortLevel.InsertionSortStep(opt3, 1,0); //just for fast debug

            int [] levels = SortLevel.KnuthSequence(48);
            

            Console.ReadLine();

        }

    }

}
