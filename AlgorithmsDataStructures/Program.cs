using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



namespace AlgorithmsDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            PowerSet<string> aaa = new PowerSet<string>();

            PowerSet<string> bbb = new PowerSet<string>();
            aaa.Put("1");
            aaa.Put("2");
            bbb.Put(null);
            var ccc= aaa.Union(bbb);
            PowerSet<int> ttt = new PowerSet<int>();
            
                       
        }
    }

}
