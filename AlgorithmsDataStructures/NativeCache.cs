using System;
using System.Linq;

namespace AlgorithmsDataStructures
{
    class NativeCache<T>
    {
        private int size;
        private int occupied;
        public string[] slots;
        public T[] values;
        public int[] hits;
        public int collisions;
        int step = 3;

        public NativeCache(int sz)
        {
            size = sz;
            occupied = 0;
            collisions = 0;
            slots = new string[size];
            values = new T[size];
            hits = new int[size];
        }
        public int SeekSlot(string value, string ToCompare)
        {
            // находит индекс пустого слота для значения, или -1
            // метод последовательных проб
            int index = HashFun(value);
            int iteration = 0;
                     
            if (slots[index] == ToCompare)
            {
                return index;
            }
            else
            {
                collisions++;
                while (index + step < size)
                {
                    index += step;
                    if (slots[index] == ToCompare)
                    {
                       return index;
                    }
                }
                index = iteration;
                while (iteration < step)
                {
                    
                    if (slots[index] == ToCompare)
                    {
                        return index;
                    }
                    else
                    {
                        while (index + step < size)
                        {
                            index += step;
                            if (slots[index] == ToCompare)
                            {

                                return index;
                            }
                            collisions++;
                        }
                        iteration++;
                        index = iteration;
                    }
                }
                return -1;
            }

        }

        public int HashFun(string key)
        {
           int hash = 0;
           for (int i = 0; i < key.Length; i++)
            {
                int code = (int)key[i];
                hash = (hash * 223 + code) % size; //элементарная хэш функция из предыдущего занятия
            }
            return hash;
        }


        public void Put(string key, T value)
        {
            // гарантированно записываем 
            // значение value по ключу key
            if (key != null)
            { 
                if (occupied<size) //проверка на заполненность кэша
                {
                    int index = SeekSlot(key, null);  //поиск индекса для записи согласно методу последовательных проб
                    occupied++;                 //счетчик заполненных ячеек
                    slots[index] = key;         //записываем key в массив ключей
                    values[index] = value;      // записываем value в массив значений по тому же индексу

                }
                else
                {
                    int ind = Array.IndexOf(hits, hits.Min());  //находим минимальное значение запрошенных страниц (используется LINQ)
                    slots[ind] = key;                           //перезаписываем по тому же индексу
                    values[ind] = value;
                    hits[ind]=0;                                //обнуляем счётчик запросов для данного значения
                }
            }
        }
        public T Get(string key)
        {
            // возвращает value для key, 
            // или null если ключ не найден

            int index = SeekSlot(key,key); //получаем индекс от хэш функции
            if (index != -1) //проверяем наличие по индексу от хэш функции
            {
                hits[index]++; // увеличиваем счетчик запросов по данному индексу
                return values[index]; //возвращаем значение 
            }
            else return default(T);
        }

    }
}
