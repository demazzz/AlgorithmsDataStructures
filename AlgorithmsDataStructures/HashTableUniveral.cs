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
        public T[] slots;
        public int collisionCount=0;
        func hashFunc;

        public HashTableUniversal(int sz, int stp)
        { int[,] factor = new int[3, 3] { { 5, 7, 11 }, { 3, 5, 9 }, { 13, 17, 29 } };

            size = sz;
            step = stp;
            slots = new T[size];
            for (int i = 0; i < size; i++) slots[i] = default(T);
            funcNumber = (new Random()).Next(0, 3);
            
            hashFunc = value =>
            {
               return ((factor[funcNumber,0] * Convert.ToInt32(value)) + factor[funcNumber, 1]) % factor[funcNumber, 2] % sz;
            };
            
        }

        public int HashFun(T value)
        {
            return hashFunc(value);
            // всегда возвращает корректный индекс слота
        }

        public int SeekSlot(T value)
        {
            // находит индекс пустого слота для значения, или -1
            int index = HashFun(value);
            int iteration = 0;
            if (Convert.ToString(slots[index]) == Convert.ToString(default(T)))
            {
                return index;
            }
            else
            {
                while (index + step < size)
                {
                    index += step;
                    collisionCount++;
                    if (Convert.ToString(slots[index]) == Convert.ToString(default(T)))
                    {
                        return index;
                    }
                }
                index = iteration;
                while (iteration < size)
                {
                    collisionCount++;
                    if (Convert.ToString(slots[index]) == Convert.ToString(default(T)))
                    {
                        return index;
                    }
                    else
                    {
                        while (index + step < size)
                        {
                            collisionCount++;
                            index += step;
                            if (Convert.ToString(slots[index]) == Convert.ToString(default(T)))
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

        public int Put(T value)
        {
            // записываем значение по хэш-функции
            int index = SeekSlot(value);
            if (index != -1)
            {
                slots[index] = value;
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