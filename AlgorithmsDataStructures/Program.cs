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

            OrderedList<object> aa = new OrderedList<object>(true);
            aa.Add("AAA");
            aa.Add(1);
            aa.Add("AAB");
            aa.Add("AAC");



            Console.WriteLine( aa.Count());
            aa.Delete("AAB");
            aa.Add(0);
            aa.Add("aa");
            aa.Add(3.4);
            Console.WriteLine(aa.Count());
            Console.ReadLine(); // 0 1 2 3 3 5 5 6 8
                       
        }
    }

}
