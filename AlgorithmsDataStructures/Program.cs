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
            Node node1 = new Node(1);
            LinkedList aaa = new LinkedList();
            aaa.AddInTail(new Node(3));
            aaa.AddInTail(new Node(1));
           
            aaa.AddInTail(new Node(1));
         
            //aaa.AddInTail(new Node(3));
            //aaa.AddInTail(new Node(1));
            aaa.RemoveAll(1);

            Console.ReadLine();
            

        }
    }
  
}
