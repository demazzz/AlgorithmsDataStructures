﻿using System;
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
            LinkedList2 aaa = new LinkedList2();
            //aaa.AddInTail(new Node(1));
            //aaa.AddInTail(new Node(1));
            //aaa.AddInTail(new Node(2));
            //aaa.AddInTail(new Node(2));
            //aaa.AddInTail(new Node(3));
            //aaa.AddInTail(new Node(4));
            aaa.AddInTail(new Node(1));
            aaa.AddInTail(new Node(2));
            aaa.AddInTail(new Node(2));
            //aaa.AddInTail(new Node(1));
            //aaa.AddInTail(new Node(1));
            //aaa.AddInTail(new Node(0));
            //aaa.AddInTail(new Node(2));
            //aaa.AddInTail(new Node(2));
            //aaa.AddInTail(new Node(2));
            //aaa.AddInTail(new Node(1));
            //aaa.AddInTail(new Node(2));
            //aaa.AddInTail(new Node(3));
            //aaa.AddInTail(new Node(3));

            aaa.Remove(2);

            Console.ReadLine();


        }
    }

}
