using System.Collections.Generic;
using System;
using System.IO;

namespace AlgorithmsDataStructures
{
    public class BloomFilter
    {
        public int filter_len;
        byte[] array;

        public BloomFilter(int f_len)
        {
            filter_len = f_len;
            array = new byte[filter_len];

            // создаём битовый массив длиной f_len ...
        }

        // хэш-функции
        public int Hash1(string str1)
        {
            // 17
            int hash1 = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                int code = (int)str1[i];
                hash1 = (hash1 * 17 + code)%filter_len;
            }
            // реализация ...
            
            return hash1;
        }
        public int Hash2(string str1)
        {
            // 223
            // реализация ...
            int hash2 = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                int code = (int)str1[i];
                hash2 = (hash2 * 223 + code) % filter_len;
            }
            return hash2;
        }

        public void Add(string str1)
        {
            // добавляем строку str1 в фильтр
            if (str1 != null)
            {
                array[Hash1(str1)] = 1;
                array[Hash2(str1)] = 1;
            }
        }

        public bool IsValue(string str1)
        {
            // проверка, имеется ли строка str1 в фильтре
            if (str1 == null) return true;
            else
            {
                if (array[Hash1(str1)] != 0 && array[Hash2(str1)] != 0) return true;
                else return false;
            }
        }
    }
}