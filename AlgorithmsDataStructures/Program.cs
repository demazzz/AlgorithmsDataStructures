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
            for (int i =0; i< 33;i++)
            {
                aaa.Append(i);
            }
            Console.WriteLine("{0} is Count. Capacity = {1}", aaa.count.ToString(), aaa.capacity.ToString());

         
            aaa.Remove(32);
            aaa.Remove(2);
            aaa.Remove(0);
            Console.WriteLine("{0} is Count. Capacity = {1}", aaa.count.ToString(), aaa.capacity.ToString());
            Console.ReadLine();
        }
    }

}
