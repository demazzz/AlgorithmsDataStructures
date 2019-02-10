using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class HashTable
    {
        public int size;
        public int step;
        public string[] slots;

        public HashTable(int sz, int stp)
        {
            size = sz;
            step = stp;
            slots = new string[size];
            for (int i = 0; i < size; i++) slots[i] = null;
        }

        public int HashFun(string value)
        {
            // всегда возвращает корректный индекс слота
            int tot = 0;
            char[] cname;
            cname = value.ToCharArray();
            for (int i = 0; i< cname.GetUpperBound(0); i++)
            {
                tot += 37 * tot + (int)cname[i];
            }
            tot = tot % slots.GetUpperBound(0);
            if (tot < 0)
                tot += slots.GetUpperBound(0);
            return tot;
            //return 0;
        }

        public int SeekSlot(string value)
        {
            // находит индекс пустого слота для значения, или -1
            int index = HashFun(value);
            int iteration = 0;
            if (slots[index] == null)
            {
                return index;
            }
            else
            {
                while (index+step < size)
                {
                    index += step;
                    if (slots[index] == null)
                    {
                        return index;
                    }
                }
                index = iteration;
                while (iteration<size)
                {
                    
                    if (slots[index]==null)
                    {
                        return index;
                    }
                    else
                    {
                        while (index + step < size)
                        {
                            index += step;
                            if (slots[index] == null)
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

        public int Put(string value)
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

        public int Find(string value)
        {
            // находит индекс слота со значением, или -1
            int index = HashFun(value);
            int iteration = 0;
            if (slots[index] == value)
                return index;
            else
            {
                while (index + step < size)
                {
                    index += step;
                    if (slots[index] == value)
                    {
                        return index;
                    }
                }
                index = iteration;
                while (iteration < size)
                {
                    if (slots[index] == value)
                    {
                        return index;
                    }
                    else
                    {
                        while (index + step < size)
                        {
                            index += step;
                            if (slots[index] == value)
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