using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures2.Tests
{
    [TestClass()]
    public class SimpleGraphTests
    {
        SimpleGraph<int> graph = new SimpleGraph<int>(4);
        [TestMethod()]
        public void SimpleGraphTest()
        {

            //SimpleGraph graph = new SimpleGraph(4);

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
                                if (graph.IsEdge(i, j)) Assert.Fail();
                            }
                        }
                    }
                }
            }
        }

        [TestMethod()]
        public void AddEdge()
        {
            int[] arr = { 10, 15, 21, 23 };

            foreach (int item in arr)
            {
                graph.AddVertex(item);
            }
            int[] j = { 0, 0, 1, 0, 2 };
            int[] k = { 1, 2, 2, 3, 3 };
            for (int i1 = 0; i1 < j.Length; i1++)
                if (!graph.IsEdge(j[i1], k[i1]))
                {
                    graph.AddEdge(j[i1], k[i1]);
                    if (!graph.IsEdge(j[i1], k[i1]))
                        Assert.Fail();
                }
                else Assert.Fail();
        }

        [TestMethod()]
        public void removeEdge()
        {
            int[] arr = { 10, 15, 21, 23 };

            foreach (int item in arr)
            {
                graph.AddVertex(item);
            }
            int[] j = { 0, 0, 1, 0, 2 };
            int[] k = { 1, 2, 2, 3, 3 };
            for (int i1 = 0; i1 < j.Length; i1++)
                if (!graph.IsEdge(j[i1], k[i1]))
                {
                    graph.AddEdge(j[i1], k[i1]);
                    if (!graph.IsEdge(j[i1], k[i1]))
                        Assert.Fail();
                }
                else Assert.Fail();

            if (!graph.IsEdge(0, 3)) Assert.Fail();
            graph.RemoveEdge(0, 3);
            if (graph.IsEdge(0, 3)) Assert.Fail();
        }

        [TestMethod()]
        public void deleteverted()
        {
            int[] arr = { 10, 15, 21, 23 };

            foreach (int item in arr)
            {
                graph.AddVertex(item);
            }
            int[] j = { 0, 0, 1, 0, 2 };
            int[] k = { 1, 2, 2, 3, 3 };
            for (int i1 = 0; i1 < j.Length; i1++)
                if (!graph.IsEdge(j[i1], k[i1]))
                {
                    graph.AddEdge(j[i1], k[i1]);
                    if (!graph.IsEdge(j[i1], k[i1]))
                        Assert.Fail();
                }
                else Assert.Fail();

            if (!graph.IsEdge(0, 3)) Assert.Fail();
            graph.RemoveEdge(0, 3);
            if (graph.IsEdge(0, 3)) Assert.Fail();

            int edgecount = 0;
            for (int i2=0;i2<graph.max_vertex;i2++)
            {
                if (!graph.IsEdge(1, i2))
                    edgecount++;
            }
            if (edgecount == graph.max_vertex) Assert.Fail();
                graph.RemoveVertex(1);
             edgecount = 0;
            for (int i2 = 0; i2 < graph.max_vertex; i2++)
            {
                if (!graph.IsEdge(1, i2))
                    edgecount++;
            }
            if (edgecount != graph.max_vertex ) Assert.Fail();
            graph.output();
            
        }

        [TestMethod()]
        public void depth()
        {
            var list = graph.DepthFirstSearch(0, 3);
        }

      
    }
}