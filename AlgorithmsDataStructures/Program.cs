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
    class Program
    {
        static void Main(string[] args)
        {

            aBST aBST = new aBST(3);
            aBST.AddKey(50);
            int a2 = aBST.AddKey(25);
            Console.ReadLine();

        }
    }

}
