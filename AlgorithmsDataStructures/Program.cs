using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using AlgorithmsDataStructures2;



namespace AlgorithmsDataStructures
{
    public class Program
    {
        static void Main(string[] args)
        {

            int[] aa = new int[] { 15,14,13,12,11,10,9,8,7,6,5,4,3,2,1 };
            var bb = BalancedBST.GenerateBBSTArray(aa);

            Console.ReadLine();

        }

    }

}
