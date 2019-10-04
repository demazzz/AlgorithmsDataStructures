using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures2
{
    public class Vertex<T>
    {
        public bool Hit;
        public T Value;
        public Vertex(T val)
        {
            Value = val;
            Hit = false;
        }
    }

    public class SimpleGraph<T>
    {
        public Vertex<T>[] vertex;
        public int[,] m_adjacency;
        public int max_vertex;

        public SimpleGraph(int size)
        {
            max_vertex = size;
            m_adjacency = new int[size, size];
            vertex = new Vertex<T>[size];
        }

        public void AddVertex(T value)
        {
            // ваш код добавления новой вершины 
            // с значением value 
            // в свободную позицию массива vertex
            for (int i=0; i<max_vertex; i++)
            {
                if (vertex[i] == null)
                {
                    vertex[i]= new Vertex<T>(value);
                    return;
                }
                
            }
            return;

        }

        // здесь и далее, параметры v -- индекс вершины
        // в списке  vertex
        public void RemoveVertex(int v)
        {
            // ваш код удаления вершины со всеми её рёбрами
            vertex[v].Value = default(T);
            for (int i =0; i<max_vertex; i++)
            {
                RemoveEdge(v, i);
            }
        }

        public bool IsEdge(int v1, int v2)
        {
            // true если есть ребро между вершинами v1 и v2
            if (m_adjacency[v1, v2] == 1 && m_adjacency[v2, v1] == 1)
                return true;
            else
            return false;
        }

        public void AddEdge(int v1, int v2)
        {
            m_adjacency[v1, v2] = 1;
            m_adjacency[v2, v1] = 1;
            // добавление ребра между вершинами v1 и v2
        }

        public void RemoveEdge(int v1, int v2)
        {
            m_adjacency[v1, v2] = 0;
            m_adjacency[v2, v1] = 0;
            // удаление ребра между вершинами v1 и v2
        }

        public void output()
        {
            for(int i =0; i<max_vertex;i++)
            {
                for (int j=0;j<max_vertex;j++)
                {
                    Console.Write(m_adjacency[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------");
        }
        public List<Vertex<T>> DepthFirstSearch(int VFrom, int VTo)
        {
            // Узлы задаются позициями в списке vertex.
            // Возвращается список узлов -- путь из VFrom в VTo.
            // Список пустой, если пути нету.

            List<Vertex<T>> list = new List<Vertex<T>>();
            Stack<Vertex<T>> stack = new Stack<Vertex<T>>();
            foreach(Vertex<T> vert in vertex)
            { vert.Hit = false; }

            Vertex<T> tempvertex = vertex[VFrom];
            tempvertex.Hit = true;
            stack.Push(tempvertex);
            while (stack.Count > 0)
            {
                int counter = 0;
                

                tempvertex = stack.Pop();
                if (m_adjacency[indexof(tempvertex), VTo] == 1) 
                {
                    list.Add(tempvertex);
                    list.Add(vertex[VTo]);
                    
                }
                else
                {
                    for(int i =0; i<max_vertex;i++)
                    {
                        if (vertex[i].Hit==false && m_adjacency[indexof(tempvertex),i]==1)
                        {
                            vertex[i].Hit = true;
                            stack.Push(vertex[i]);
                            list.Add(tempvertex);
                            break;
                        }
                    }
                }
                foreach (Vertex<T> vert in vertex)
                {
                    if (vert.Hit == true) counter++;
                    if (counter == max_vertex) return list;
                }
            }

            return list;
        }

        public List<Vertex<T>> BreadthFirstSearch(int VFrom, int VTo)
        {
            // узлы задаются позициями в списке vertex.
            // возвращает список узлов -- путь из VFrom в VTo
            // или пустой список, если пути нету

            List<Vertex<T>> list = new List<Vertex<T>>();
            Queue <Vertex< T>> query = new Queue<Vertex<T>>();
            foreach (Vertex<T> vert in vertex)
            { vert.Hit = false; }
            int level = 0;

            Vertex<T> tempvertex = vertex[VFrom];
            tempvertex.Hit = true;
            query.Enqueue(tempvertex);
            
            while (query.Count>0)
            {
                tempvertex = query.Dequeue();
                
                for(int i=0;i<max_vertex;i++)
                {
                    if (vertex[i].Hit==false && m_adjacency[indexof(tempvertex),i] ==1)
                    {
                        
                        query.Enqueue(vertex[i]);
                        vertex[i].Hit = true;

                        if (!list.Contains(tempvertex)) list.Add(tempvertex);
                        if (vertex[i]==vertex[VTo])
                        { 
                            list.Add(vertex[i]);
                            return list;
                        }
                        
                    }
                    
                }
                level++;
            }
            
            return list;
        }

        public List<Vertex<T>> WeakVertices()
        {
            // возвращает список узлов вне треугольников
            List<Vertex<T>> output = new List<Vertex<T>>();

            List<Vertex<T>> hasthree = new List<Vertex<T>>();
            
            for(int i = 0;i<max_vertex;i++)
            {
                
                for (int j =0;j<max_vertex;j++)
                {
                    if (IsEdge(i,j))
                    {
                        for (int z= 0; z<max_vertex;z++)
                        {
                            if (IsEdge(z, j))
                            {
                                if (IsEdge(i, z))
                                {
                                    hasthree.Add(vertex[i]);
                                    hasthree.Add(vertex[j]);
                                    hasthree.Add(vertex[z]);
                                }
                            }
                        }
                    }
                }
            }
            for (int i1=0;i1<max_vertex;i1++)
            {
                if (!hasthree.Contains(vertex[i1]))
                { output.Add(vertex[i1]); }
            }

            return output;
        }

        private int indexof(Vertex<T> input)
        {
            int index=0;
            for (int i =0;i<max_vertex;i++)
            {
                if (vertex[i].Equals(input))
                    index = i;
            }
            return index;
        }
    }
}