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
            LinkedList aaa = new LinkedList();
            //aaa.AddInTail(new Node(3));
            aaa.AddInTail(new Node(1));
           // aaa.AddInTail(new Node(2));
            //aaa.AddInTail(new Node(3));
            aaa.AddInTail(new Node(2));
            //aaa.AddInTail(new Node(3));
            aaa.AddInTail(new Node(3));

            //
            List<Node> lll = new List<Node>();
            lll=(aaa.FindAll(3));

            Console.ReadLine();
            

        }
    }
  
}
