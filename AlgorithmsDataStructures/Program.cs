using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using AlgorithmsDataStructures2;



namespace AlgorithmsDataStructures
{
    public class Program
    {
        static void Main(string[] args)
        {

           //int []arr = { 1, 3, 5, 4, 6, 13, 10, 9, 8, 15, 17,2,124,244,11,111 };  
           //int n = arr.Length;
            //SimpleGraph graph = new SimpleGraph(4);
            //graph.AddVertex(10);
            //graph.AddVertex(15);
            //graph.AddVertex(21);
            //graph.AddVertex(23);

            //graph.AddEdge(0, 1);
            //graph.AddEdge(0, 2);
            //graph.AddEdge(1, 2);
            //graph.AddEdge(0, 3);
            //graph.AddEdge(2, 3);
            //graph.output();
            //graph.RemoveEdge(0, 3);
            //graph.output();
            //graph.AddVertex(30);//nothing should change
            //graph.output();
            //graph.AddEdge(1,1);
            //graph.output();
            //graph.RemoveVertex(1);
            //graph.output();

            SimpleGraph graph = new SimpleGraph(4);

            int[] arr = { 10, 15, 21, 23 };

            foreach (int item in arr)
            {
                graph.AddVertex(item);
                for (int i = 0; i < graph.max_vertex; i++)
                {
                    if (graph.vertex[i] != null)
                    {
                        if (graph.vertex[i].Value == item)
                        {
                            for (int j = 0; j < graph.max_vertex; j++)
                            {
                                if (graph.IsEdge(i, j)) Console.WriteLine("FAIL");
                                else Console.WriteLine("no edges !!!!!!!");
                            }

                        }
                    }
                }

            }

                Console.ReadLine();

        }

    }

}
