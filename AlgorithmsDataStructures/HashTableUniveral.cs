using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{
    
    public class HashTableUniversal<T>
    {
        delegate int func(T value);
        public int size;
        public int step;
        int funcNumber;
        public List<T>[] slots;
        //public T[] slots;
        public int collisionCount=0;
        func hashFunc;
        int freeslots;

        public HashTableUniversal(int sz, int stp)
        { int[,] factor = new int[3, 3] { {16, 51, 293 }, { 4, 213, 557 }, { 15, 79, 732 } };

            size = sz;
            freeslots = sz;
            step = stp;
            //slots = new T[size];
            slots = new List<T>[size];
           // for (int i = 0; i < size; i++) slots[i] = default(List<T>);
            funcNumber = (new Random()).Next(0, 3);
            
            hashFunc = value =>
            {
               return ((factor[funcNumber,0] * Convert.ToInt32(value)) + factor[funcNumber, 1]) % factor[funcNumber, 2] % sz;
            };
            
        }

        private int HashFun(T value)
        {
            return hashFunc(value);
            // всегда возвращает корректный индекс слота
        }

        //private int SeekSlot(T value)
        //{
        //    // находит индекс пустого слота для значения, или -1
        //    if (freeslots>0)
        //    { 
        //    int index = HashFun(value);
        //    int iteration = 0;
        //        if (Convert.ToString(slots[index]) == Convert.ToString(default(T)))
        //        {
        //            return index;
        //        }
        //        else
        //        {
        //            while (index + step < size)
        //            {
        //                index += step;
        //                collisionCount++;
        //                if (Convert.ToString(slots[index]) == Convert.ToString(default(T)))
        //                {
        //                    return index;
        //                }
        //            }
        //            index = iteration;
        //            while (iteration < step)
        //            {
        //                collisionCount++;
        //                if (Convert.ToString(slots[index]) == Convert.ToString(default(T)))
        //                {
        //                    return index;
        //                }
        //                else
        //                {
        //                    while (index + step < size)
        //                    {
        //                        collisionCount++;
        //                        index += step;
        //                        if (Convert.ToString(slots[index]) == Convert.ToString(default(T)))
        //                        {
        //                            return index;
        //                        }
        //                    }
        //                    iteration++;
        //                    index = iteration;
        //                }
        //            }
        //            return -1;
        //        }
                
        //    }
        //    else
        //        return -1;

        //}
        private int SeekSlot(T value)
        {
            int index = HashFun(value);
            if (Convert.ToString(slots[index]) == Convert.ToString(default(T)))
                return index;
            else
            {
                collisionCount++;
                return -1;
            }
        }

        public int Put(T value)
        {
            // записываем значение по хэш-функции
            //int index = SeekSlot(value);
            int index = hashFunc(value);
            if (index != -1)
            {
                if (slots[index]==null)
                {
                    slots[index] = new List<T>();
                }
                slots[index].Add(value);
                return index;
            }
            else
                return -1;
            // возвращается индекс слота или -1
            // если из-за коллизий элемент не удаётся разместить 

        }

        public int Find(T value)
        {
            // находит индекс слота со значением, или -1
            int index = HashFun(value);
            int iteration = 0;
            if (Convert.ToString(slots[index]) == Convert.ToString(value))
                return index;
            else
            {
                while (index + step < size)
                {
                    index += step;
                    if (Convert.ToString(slots[index]) == Convert.ToString(value))
                    {
                        return index;
                    }
                }
                index = iteration;
                while (iteration < size)
                {
                    if (Convert.ToString(slots[index]) == Convert.ToString(value))
                    {
                        return index;
                    }
                    else
                    {
                        while (index + step < size)
                        {
                            index += step;
                            if (Convert.ToString(slots[index]) == Convert.ToString(value))
                            {
                                return index;
                            }
                        }
                        iteration++;
                        index = iteration;
                    }
                }
                return -1;
            }
        }
    }

}