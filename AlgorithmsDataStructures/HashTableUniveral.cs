using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{
    delegate int func(int value);
    public class HashTableUniversal
    {
        public int size;
        public int step;
        int funcNumber;
        public int[] slots;
        func[] hashFunc;

        public HashTableUniversal(int sz, int stp)
        {
            size = sz;
            step = stp;
            slots = new int[size];
            for (int i = 0; i < size; i++) slots[i] = 0;
            funcNumber = (new Random()).Next(0, 3);
            hashFunc = new func[3];
            hashFunc[0] = value =>
            {
                return (((10 * value + 15) % 28) % sz);
            };
            hashFunc[1] = value =>
            {
                return (((5 * value + 7) % 11) % sz);
            };
            hashFunc[2] = value =>
            {
                return (((16 * value + 12) % 37) % sz);
            };

        }

        public int HashFun(int value)
        {
            return hashFunc[funcNumber](value);
            // всегда возвращает корректный индекс слота
        }

        public int SeekSlot(int value)
        {
            // находит индекс пустого слота для значения, или -1
            int index = HashFun(value);
            int iteration = 0;
            if (slots[index] == 0)
            {
                return index;
            }
            else
            {
                while (index + step < size)
                {
                    index += step;
                    if (slots[index] == 0)
                    {
                        return index;
                    }
                }
                index = iteration;
                while (iteration < size)
                {

                    if (slots[index] == 0)
                    {
                        return index;
                    }
                    else
                    {
                        while (index + step < size)
                        {
                            index += step;
                            if (slots[index] == 0)
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

        public int Put(int value)
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

        public int Find(int value)
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