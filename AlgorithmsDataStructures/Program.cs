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

            OrderedList<string> aa = new OrderedList<string>(true);

            //aa.Add(" AB ");
            //aa.Add("AA ");


            //Console.WriteLine(aa.Count());
            //aa.Delete("AA");
            //Console.WriteLine(aa.Count());

            Console.WriteLine(aa.Compare("AB", "AA"));
            Console.WriteLine(aa.Compare("AB", "AA "));
            Console.WriteLine(aa.Compare("AB ", "AA "));
            Console.WriteLine(aa.Compare(" AB", "AA"));
            Console.WriteLine(aa.Compare(" AB  ", "AA"));
            Console.WriteLine(aa.Compare(" AB ", "AA "));
            Console.WriteLine(aa.Compare(" AB  ", "AA "));



            Console.ReadLine(); // 0 1 2 3 3 5 5 6 8
                       
        }
    }

}
