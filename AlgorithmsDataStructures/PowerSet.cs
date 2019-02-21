using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    // наследуйте этот класс от HashTable
    // или расширьте его методами из HashTable
    public class PowerSet<T>
    {   
        public List<T> slots;
        public int count;
        public int repeat = 0;
       
        public PowerSet()
        {
            // ваша реализация хранилища
            count = 0;
            slots = new List<T>();
        }
      
        public int Size()
        {
            // количество элементов в множестве
            if (count > 0) return slots.Count;
            else return 0;
        }

        public void Put(T value)
        {
            if (Get(value))
                {
                    repeat++;
                    return;
                }
                else
                {
                slots.Add(value);
                count++;
                }
             // всегда срабатывает
        }

        public bool Get(T value)
        {
            // возвращает true если value имеется в множестве,
            // иначе false
            if (count > 0)
            {
                if (slots.Contains(value)) return true;
            } 
               
            return false;
        }

        public bool Remove(T value)
        {
           if (count>0)
            {
                if (Get(value))
                {
                    slots.Remove(value);
                    count--;
                    return true;
                }
            }
            return false;
        }

        public PowerSet<T> Intersection(PowerSet<T> set2)
        {
            // пересечение текущего множества и set2
            PowerSet<T> Intersected = new PowerSet<T>();
            if (this.count >0 && set2.count>0)
            foreach (T item in slots)
            {
                if (set2.Get(item))
                Intersected.Put(item);
            }
            if (Intersected.count > 0) return Intersected;
            else return Intersected;
        }

        public PowerSet<T> Union(PowerSet<T> set2)
        {
            // объединение текущего множества и set2
            PowerSet<T> United = new PowerSet<T>();
            ///////United = this;/////
            foreach(T item in slots)
            {
                United.Put(item);
            }
            for (int i = 0; i < set2.count; i++)
            {
                United.Put(set2.slots[i]);
            }
            if (United.count > 0) return United;
            else return United;
        }

        public PowerSet<T> Difference(PowerSet<T> set2)
        {
            // разница текущего множества и set2
           
            PowerSet<T> differenced = new PowerSet<T>();
            if (set2.count == 0)
            ///return this;
            {
                foreach (T item in slots)
                {
                    differenced.Put(item);
                }
            }
            
            foreach(T item in this.slots)
            {
                if (!set2.Get(item))
                differenced.Put(item);
            }
            if (differenced.count > 0) return differenced;
            else
            return differenced;
        }

        public bool IsSubset(PowerSet<T> set2)
        {
            // возвращает true, если set2 есть
            // подмножество текущего множества,
            // иначе false
            if (this.count == 0 || set2.count == 0) return false;
            int count = set2.count;
            for (int i=0;i<set2.count;i++)
            {
                if(Get(set2.slots[i]))
                {
                    count--;
                }
            }
            if (count == 0)
                return true;
            else return false;
        }
    }
}