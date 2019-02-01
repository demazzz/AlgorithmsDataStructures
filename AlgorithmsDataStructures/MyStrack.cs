using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class Stack<T>
    {
        public List<T> stack;
        public int count;
        public Stack()
        {
            // инициализация внутреннего хранилища стека
            stack = new List<T>();
            count = 0;
        }

        public int Size()
        {
            if (stack.Count != 0)
            {
                return count;
            }// размер текущего стека		  
            else
            return 0;
        }

        public T Pop()
        {
            // ваш код
            if (stack.Count == 0)
            {
                
                return default(T); // null, если стек пустой
            }
            else
            {
                T result = stack[count - 1];
                stack.RemoveAt(count - 1);
                count--;
                return result;
            }
            
        }

        public void Push(T val)
        {
            // ваш код
            stack.Add(val);
            count++;
        }
        
        public T Peek()
        {
            // ваш код
            if (count!=0)
            {
                return stack[count - 1];
            }
            else
            return default(T); // null, если стек пустой
        }
    }

}