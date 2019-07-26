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

            int[] aa = new int[] { 1,6,7,8,9};
            var bb = new BalancedBST();
            var vv = BalancedBST2.GenerateBBSTArray(aa);
            bb.CreateFromArray(aa);
            bb.GenerateTree();
            var bal = bb.IsBalanced(bb.Root);
            Console.ReadLine();

        }

    }

}
