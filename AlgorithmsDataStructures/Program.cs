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

            for (int i = 1; i <= 33; i++)
            {
                aaa.Append(i);
                Console.WriteLine("{0} element and {1} is Count. Lenght = {2}", aaa.GetItem(i-1).ToString(), aaa.count.ToString(), aaa.array.Length.ToString());
            }
           

            for (int i = 33; i < 66; i++)
            {
                aaa.Insert((i+1)*10, i);
            }
            for (int i = aaa.count; i > 0; i--)
            {
                
                Console.WriteLine("{0} element and {1} is Count. Lenght = {2}", aaa.GetItem(i).ToString(), aaa.count.ToString(), aaa.array.Length.ToString());
                aaa.Remove(i);
                

            }
            Console.WriteLine("{0} is Count. Lenght = {1}", aaa.count.ToString(), aaa.array.Length.ToString());
            Console.ReadLine();
        }
    }

}
