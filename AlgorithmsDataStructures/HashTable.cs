using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class HashTable<T>
    {
        public int size;
        public int step;
        public T[] slots;

        public HashTable(int sz, int stp)
        {
            size = sz;
            step = stp;
            slots = new T[size];
            for (int i = 0; i < size; i++) slots[i] = default(T);
        }

        public int HashFun(T value)
        {
            // всегда возвращает корректный индекс слота
            int number = 0; for (int i = 0; i < value.ToString().Length; i++)
            {
                number += Convert.ToInt32(value.ToString()[i]);
            }
            return (15 * number + 79) % 732 % size;
            //return 0;
        }

        public int SeekSlot(T value)
        {
            // находит индекс пустого слота для значения, или -1
            int index = HashFun(value);
            int iteration = 0;
            int freeslots = size;
            if (freeslots==0)
            {
                T[] _slots = new T[size * 2];
                _slots = slots;
                slots = _slots;
            }
            if (slots[index].ToString() == default(T).ToString())
            {
                freeslots--;
                return index;
                
            }
            else
            {
                while (index + step < size)
                {
                    index += step;
                    if (slots[index].ToString() == default(T).ToString())
                    {
                        freeslots--;
                        return index;
                    }
                }
                index = iteration;
                while (iteration < step)
                {

                    if (slots[index].ToString() == default(T).ToString())
                    {
                        freeslots--;
                        return index;
                    }
                    else
                    {
                        while (index + step < size)
                        {
                            index += step;
                            if (slots[index].ToString() == default(T).ToString())
                            {
                                freeslots--;
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
            if (slots[index].ToString() == value.ToString())
                return index;
            else
            {
                while (index + step < size)
                {
                    index += step;
                    if (slots[index].ToString() == value.ToString())
                    {
                        return index;
                    }
                }
                index = iteration;
                while (iteration < size)
                {
                    if (slots[index].ToString() == value.ToString())
                    {
                        return index;
                    }
                    else
                    {
                        while (index + step < size)
                        {
                            index += step;
                            if (slots[index].ToString() == value.ToString())
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