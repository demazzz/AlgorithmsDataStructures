using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class DynArray<T>
    {
        public T[] array;
        public int count;
        public int capacity;

        public DynArray()
        {
            count = 0;
            MakeArray(16);
        }

        public void MakeArray(int new_capacity)
        {
            // ваш код
            if (new_capacity < 16)
                new_capacity = 16;
            T[] newArray = new T[new_capacity]; //создаем новый массив заданной длины
            if (array !=null && array.Length<new_capacity)
            Array.Copy(array,0,newArray,0,count); //копируем все данные в него
            if (array != null && array.Length > new_capacity)
                Array.Copy(array, 0, newArray, 0, count + 1); //копируем все данные в него

            array = newArray; //присваиваем ему имя array
        }

        public T GetItem(int index)
        {
            // ваш код
            //проверка на индекс
            if (index <= count)
                return array[index];

            else
            {
                throw new IndexOutOfRangeException();
                return default(T);
            }
        }

        public void Append(T itm)
        {
            // ваш код
            if (array.Length==count)
            {
                MakeArray(array.Length * 2);
            }
            array[count++] = itm;
        }

        public void Insert(T itm, int index)
        {
            if (index>count)
            {
                throw new IndexOutOfRangeException();
            }
            if (index == count)
            {
                Append(itm);
                
            }
            
                if (array.Length == count)
                {
                    this.MakeArray(count * 2);
                }
                //из текущего 5 4 3 2 1 берём все с индекса 2 (3) 
                //вставляем в индекса 2+1 длиной 3 = 5-2
                Array.Copy(array, index, array, index + 1, count-index);
                array[index] = itm;
                count++;
                // ваш код
            
        }

        //public void Remove(int index)
        //{
        //    if (index >= count)
        //    {
        //        throw new IndexOutOfRangeException();
        //    }

        //    int shiftStart = index + 1;
        //    if (shiftStart < count)
        //    {
        //        // Shift all the items following index one slot to the left.
        //        Array.Copy(array, shiftStart, array, index, count - shiftStart);
        //    }

        //    count--;
        //}
        public void Remove(int index)
        {
            if (index > count)
            {
                throw new IndexOutOfRangeException();
            }
            if (index <= count)
            {   //было 5 4 3 2 1
                //стало 5 4 2 1
                //индекс 2 (3) из исходного вектора копируется 2 и 1 в исходный массив, при этом длина 5 - 2 + 1 = 4
                Array.Copy(array, index + 1, array, index, count - index + 1);
            }
            count--;
            //Count был 33 - lenght 64, стал 32, значит надо сделать новый массив length 32
            //проверка 32*2 > length? если да, то ничего не делаем, если нет или равно то можно уменьшать
            if (count * 2 <= array.Length + 1 && array.Length > 16)
            {
                float newSize = array.Length / 1.5f;
                int n = (int)newSize;
                MakeArray((n));
            }

            // ваш код
        }

    }
}