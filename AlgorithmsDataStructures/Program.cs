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

            queues_additions mystack = new queues_additions();

            mystack.Enqueue(1);
            mystack.Enqueue("2");
            mystack.Enqueue(3.14);
            mystack.Enqueue(4);
            mystack.Enqueue(5);
            mystack.Enqueue(6);

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
