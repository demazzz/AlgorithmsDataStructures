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

           int []arr = { 1, 3, 5, 4, 6, 13, 10, 9, 8, 15, 17,2,124,244,11,111 };  
           int n = arr.Length;  
           Heap heap = new Heap();

           heap.MakeHeap(arr,4);
           Console.ReadLine();

        }

    }

}
