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
            SimpleGraph<int> graph = new SimpleGraph<int>(6);
            graph.AddVertex(10);
            graph.AddVertex(15);
            graph.AddVertex(21);
            graph.AddVertex(23);
            graph.AddVertex(33);
            graph.AddVertex(46);

            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 2);
            graph.AddEdge(0, 3);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 4);
            graph.AddEdge(5, 4);
            graph.output();
            graph.RemoveEdge(0, 3);
            graph.output();
            graph.AddVertex(30);//nothing should change
            graph.output();
            graph.AddEdge(1, 1);
            ////graph.AddEdge(0, 1);
            ////graph.AddEdge(0, 2);
            ////graph.AddEdge(0, 4);
            ////graph.AddEdge(1, 5);
            ////graph.AddEdge(2, 3);


            graph.output();
           // graph.RemoveVertex(1);
            graph.output();
            var list = graph.DepthFirstSearch(5, 0);
            var list2 = graph.BreadthFirstSearch(5, 0);
            int countsame = 0;
            if (list.Count == list2.Count)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Value != list2[i].Value) countsame++;
                }
            }
            else countsame = -150;
            {//SimpleTreeNode<int> a1 = new SimpleTreeNode<int>(1, null);
             //SimpleTreeNode<int> b1 = new SimpleTreeNode<int>(2, a1);
             //SimpleTreeNode<int> b2 = new SimpleTreeNode<int>(3, a1);
             //SimpleTreeNode<int> b3 = new SimpleTreeNode<int>(6, a1);
             //SimpleTreeNode<int> c1 = new SimpleTreeNode<int>(5, b1);
             //SimpleTreeNode<int> c2 = new SimpleTreeNode<int>(7, b1);
             //SimpleTreeNode<int> c3 = new SimpleTreeNode<int>(4, b2);
             //SimpleTreeNode<int> c4 = new SimpleTreeNode<int>(8, b3);
             //SimpleTreeNode<int> d1 = new SimpleTreeNode<int>(9, c4);
             //SimpleTreeNode<int> d2 = new SimpleTreeNode<int>(10, c4);
             ////SimpleTreeNode<int> TEMP = new SimpleTreeNode<int>(11, c3);
             ////SimpleTreeNode<int> TEMP2 = new SimpleTreeNode<int>(12, TEMP);
             //SimpleTree<int> tree = new SimpleTree<int>(a1);
             //tree.AddChild(a1, b1);
             //tree.AddChild(a1, b2);
             //tree.AddChild(a1, b3);
             //tree.AddChild(b1, c1);
             //tree.AddChild(b1, c2);
             //tree.AddChild(b2, c3);
             //tree.AddChild(b3, c4);
             //tree.AddChild(c4, d1);
             //tree.AddChild(c4, d2);
             ////tree.AddChild(c3, TEMP);
             ////tree.AddChild(TEMP, TEMP2);
             //List<int> list = tree.EvenTrees();
            }
            Console.ReadLine();

        }

    }

}
