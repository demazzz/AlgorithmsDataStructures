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

            OrderedList<int> aa = new OrderedList<int>(true);
            //aa.Add(1);
            aa.Delete(2);
            Console.ReadLine(); // 0 1 2 3 3 5 5 6 8
                       
        }
    }

}
