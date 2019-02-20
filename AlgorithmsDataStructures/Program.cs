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
           

            PowerSet<int> ttt = new PowerSet<int>();
            Random rand = new Random();
            for(int i = 0;i<100; i++)
            {
                ttt.Put(rand.Next(0,100));
            }

            bool a = ttt.Get(12);
            bool b = ttt.Get(14);
            bool c = ttt.Get(134);
            bool d = ttt.Get(156);
            Console.ReadLine(); // 0 1 2 3 3 5 5 6 8
                       
        }
    }

}
