using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AlgorithmsDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            
          
            DynArray<int> aaa = new DynArray<int>();
            aaa.Append(1);
            aaa.Append(2);
            aaa.Append(3);
            aaa.Append(4);
            aaa.Remove(0);
            aaa.Remove(2);
            Console.WriteLine("{0} is Count. Capacity = {1}", aaa.count.ToString(), aaa.capacity.ToString());
            Console.ReadLine();
        }
    }

}
