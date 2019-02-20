using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class NativeDictionary<T>
    {
        delegate int func(string value);
        public int size;
        public string[] slots;
        public T[] values;
        func hashFunc;

        public NativeDictionary(int sz)
        {
            int[,] factor = new int[3, 3] { { 16, 51, 293 }, { 4, 213, 557 }, { 15, 79, 732 } };
            size = sz;
            slots = new string[size];
            values = new T[size];
            int funcNumber = (new Random()).Next(0, 3);
            hashFunc = value =>
            {
                if (typeof(T)== typeof(string))
                {
                    int number=0; for(int i = 0; i <value.Length;i++)
                    {
                        number += Convert.ToInt32(value[i]);
                    }
                    return ((factor[funcNumber, 0] * number + factor[funcNumber, 1]) % factor[funcNumber, 2] % sz);
                }
                else return ((factor[funcNumber, 0] * Convert.ToInt32(value) + factor[funcNumber, 1]) % factor[funcNumber, 2] % sz);
            };
        }

        public int HashFun(string key)
        {
            // всегда возвращает корректный индекс слота
            return hashFunc(key);
            
        }

        public bool IsKey(string key)
        {
            // возвращает true если ключ имеется,
            // иначе false
            if (slots[HashFun(key)] == key)
                return true;
            else return false;
        }

        public void Put(string key, T value)
        {
            // гарантированно записываем 
            // значение value по ключу key
            slots[HashFun(key)] = key;
            values[HashFun(key)] = value;
        }

        public T Get(string key)
        {
            // возвращает value для key, 
            // или null если ключ не найден
            if (IsKey(key))
            {
                return values[hashFunc(key)];
            }
            else return default(T);
        }
    }
}