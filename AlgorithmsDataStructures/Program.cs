using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



namespace AlgorithmsDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[100];
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                values[i] = rand.Next(0, 1000);
                Thread.Sleep(10);
            }

            NativeDictionary<int> ttt = new NativeDictionary<int>(23);
            
            ttt.Put("1", 12);
            ttt.Put("aab", 122);
            ttt.Put("ac", 132);
            ttt.Put("a", 14);
            ttt.Put("a", 0);
            int a = ttt.Get("1");
            int b = ttt.Get("aab");
            int c = ttt.Get("a");
            int d = ttt.Get("aaaaaa");
            Console.ReadLine(); // 0 1 2 3 3 5 5 6 8
                       
        }
    }

}
