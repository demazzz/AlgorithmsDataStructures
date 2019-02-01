using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures
{
    public class queues_additions
    {
        public Stack<object> s1;
        Stack<object> s2;
        public queues_additions()
        {
            s1 = new Stack<object>();
            s2 = new Stack<object>();
        }
        public int size()
        {
            if (s1.count > 0)
                return s1.count;
            else
            return 0;
        }
        public object Dequeue()
        {
            if (s1.count != 0)
            {
                object result = default(object);
                while(s1.count>1)
                {
                    s2.Push(s1.Pop());
                }
                result = s1.Pop();
                while (s2.count > 0)
                {
                    s1.Push(s2.Pop());
                }

                return result;
            }
            else
                return default(object);
        }
        public void Enqueue(object item)
        {
            s1.Push(item);
        }
    }
}
