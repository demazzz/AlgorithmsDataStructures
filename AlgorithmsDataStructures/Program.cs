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

            aBST aBST = new aBST(4);
            int[] keys = new int[10] { 50, 25, 75, 37, 62, 84, 31, 43, 55, 92 };
            foreach(int key in keys)
            {
                aBST.AddKey(key);
            }
            List<int?> indexes = new List<int?>();
            int[] indexx = new int[11] { 92, 50, 37, 25, 75, 62, 84, 43, 31, 55, 81 };
            foreach(int key in indexx)
            {
                indexes.Add(aBST.FindKeyIndex(key));
            }
            int[] add = new int[6] { 21, 19, 23, 63, 80, 1 };
            List<int?> responces = new List<int?>();
            foreach(int iii in add)
            {
                responces.Add(aBST.AddKey(iii));
            }
            indexes.Clear();
            int[] indexx_final = new int[17] { 92, 50, 37, 25, 75, 62, 84, 43, 31, 55, 81,21,19,23,63,80,1 };
            foreach(int xni in indexx_final)
            {
                indexes.Add(aBST.FindKeyIndex(xni));
            }
            Console.ReadLine();

        }
    }

}
