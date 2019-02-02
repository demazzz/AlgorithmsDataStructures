using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    class Deque<T>
    {
        List<T> list;
        int count;
        public Deque()
        {
            list = new List<T>();
            count = 0;
            // инициализация внутреннего хранилища
        }

        public void AddFront(T item)
        {
            list.Insert(0, item);
            count++;
            // добавление в голову
        }

        public void AddTail(T item)
        {
            list.Add(item);
            count++;
            // добавление в хвост
        }

        public T RemoveFront()
        {
            if (count > 0)
            {
                T resul = list[0];
                list.RemoveAt(0);
                count--;
                return resul;
            }
            else
                return default(T);
        }

        public T RemoveTail()
        {
            // удаление из хвоста
            if (count > 0)
            {
                T result = list[count - 1];
                list.RemoveAt(count - 1);
                count--;
                return result;
            }
            else
                return default(T);
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