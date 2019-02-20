﻿using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class NativeDictionary<T>
    {
        
        public int size;
        public string[] slots;
        public T[] values;
        

        public NativeDictionary(int sz)
        {
            
            size = sz;
            slots = new string[size];
            values = new T[size];
        }

        public int HashFun(string key)
        {
            
            // всегда возвращает корректный индекс слота
            {
                if (typeof(T) == typeof(string))
                {
                    if (key != null)
                    {
                        int number = 0; for (int i = 0; i < key.Length; i++)
                        {
                            number += Convert.ToInt32(key[i]);
                        }
                        return (15 * number + 79) % 732 % size;
                    }
                    else return 0;
                }
                else return (15 * Convert.ToInt32(key) + 79) % 732 % size;
            };

        }

        public bool IsKey(string key)
        {
            // возвращает true если ключ имеется,
            // иначе false

            if (slots[HashFun(key)] == key)
                return true;
            return false;
        }

        public void Put(string key, T value)
        {
            // гарантированно записываем 
            // значение value по ключу key
            if (key != null)
            {
                slots[HashFun(key)] = key;
                values[HashFun(key)] = value;
            }
        }

        public T Get(string key)
        {
            // возвращает value для key, 
            // или null если ключ не найден
            if (IsKey(key))
            {
                return values[HashFun(key)];
            }
            else return default(T);
        }
    }
}