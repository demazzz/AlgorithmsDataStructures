using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class Queue<T>
    {
        public List<T> list;
        public int count;
        public Queue()
        {
            // инициализация внутреннего хранилища очереди
            list = new List<T>();
            count = 0;
        }

        public void Enqueue(T item)
        {
            list.Add(item);
            count++;
            // вставка в хвост
        }

        public T Dequeue()
        {
            if (list.Count>0)
            {
                T item =  list[0];
                list.RemoveAt(0);
                count--;
                return item;
            }
            else
            // выдача из головы
            return default(T); // если очередь пустая
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