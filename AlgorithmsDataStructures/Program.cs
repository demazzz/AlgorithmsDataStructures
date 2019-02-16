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
            int[] values = new int[20] {3434, 545, 234, 123456, 56 ,434,1234,645,251,345,342,123,654,34,34,52,45,765,34,48};
            HashTableUniversal ttt = new HashTableUniversal(19, 2);
            Thread.Sleep(100);
            HashTableUniversal ttt2 = new HashTableUniversal(19, 2);
            Thread.Sleep(100);
            HashTableUniversal ttt3 = new HashTableUniversal(19, 2);
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
