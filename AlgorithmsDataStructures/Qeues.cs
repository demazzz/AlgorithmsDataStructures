using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class Queue<T>
    {
        public List<T> List;
        public int count;
        public Queue()
        {
            // инициализация внутреннего хранилища очереди
            List = new List<T>();
            count = 0;
        }

        public void Enqueue(T item)
        {
            List.Add(item);
            count++;
            // вставка в хвост
        }

        public T Dequeue()
        {
            if (List.Count>0)
            {
                T item =  List[0];
                List.RemoveAt(0);
                count--;
                return item;
            }
            else
            // выдача из головы
            return default(T); // если очередь пустая
        }
        public void rotate(int N)
        {
            for (int i=0;i<N;i++)
            {
                List.Add(List[0]);
                List.RemoveAt(0);
            }
            return;

        }
        public int Size()
        {
            if (count > 0)
                return count;
            else
            return 0; // размер очереди
        }

    }
}