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

            NativeDictionary<string> ttt = new NativeDictionary<string>(23);
            Thread.Sleep(100);
            NativeDictionary<string> ttt2 = new NativeDictionary<string>(23);
            Thread.Sleep(100);
            NativeDictionary<string> ttt3 = new NativeDictionary<string>(23);
            ttt.Put("aaa", "aaa word");
            ttt.Put("aab", "aab word");
            ttt.Put("ac", "ac word");
            ttt.Put("a", "a word");
            ttt.Put("a", null);
            string a = ttt.Get("aaa");
            string b = ttt.Get("a");
            string c = ttt.Get("ac");
            string d = ttt.Get("aaaaaa");
            Console.ReadLine(); // 0 1 2 3 3 5 5 6 8
                       
        }
    }

}
