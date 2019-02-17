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
            for (int i = 0; i<100; i++)
            {
                
                
                values[i] = rand.Next(0, 100);
                Thread.Sleep(10);

            }
            
            HashTableUniversal<int> ttt = new HashTableUniversal<int>(23, 3);
            Thread.Sleep(100);
            HashTableUniversal<int> ttt2 = new HashTableUniversal<int>(23, 3);
            Thread.Sleep(100);
            HashTableUniversal<int> ttt3 = new HashTableUniversal<int>(23, 3);
            foreach (int item in values)
            {
                ttt.Put(item);
                ttt2.Put(item);
                ttt3.Put(item);
            }

            Console.ReadLine(); // 0 1 2 3 3 5 5 6 8
                       
        }
    }

}
