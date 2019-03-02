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

            NativeCache<int> cache = new NativeCache<int>(11);
            int[] arr = new int[11] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            string[] arrS = new string[11] { "a", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K" };
            for (int i =0;i<11;i++)
            {
                cache.Put(arrS[i], arr[i]);
            }
            Random RAND = new Random();
            for (int i=0;i<50;i++)
            {
                cache.Get(arrS[RAND.Next(0, 11)]);
            }
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("Value {0} has {1} hits", cache.values[i],cache.hits[i]);
            }
            cache.Put("AA", 100);
            for (int i = 0; i < 10; i++)
            {
                cache.Get("AA");
            }
            cache.Put("CC", 300);
            for (int i = 0; i < 10; i++)
            {
                cache.Get("CC");
            }
            cache.Put("BB", 200);
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("Value {0} has {1} hits", cache.values[i], cache.hits[i]);
            }
            Console.ReadLine();
        }
    }

}
