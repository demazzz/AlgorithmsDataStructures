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

            Queue<object> mystack = new Queue<object>();
            mystack.Enqueue(1);
            mystack.Enqueue("2");
            mystack.Enqueue(3.14);
            Console.WriteLine(mystack.Dequeue().ToString());
           // Console.WriteLine(mystack.Size().ToString());
            Console.WriteLine(mystack.Dequeue().ToString());
           // Console.WriteLine(mystack.Size().ToString());
            Console.WriteLine(mystack.Dequeue().ToString());
           // Console.WriteLine(mystack.Size().ToString());
            Console.ReadLine();




            Console.ReadLine();
            
        }
    }

}
