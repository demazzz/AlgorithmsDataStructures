using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures
{
    public static class balance
    {
        public static bool balanced(string brakets_in)
        {
            Stack<char> mystack = new Stack<char>();
            char temp = default(char);
            for (int i = 0; i < brakets_in.Length; i++)
            {
                if (brakets_in[i] == '(')
                    mystack.Push(brakets_in[i]);
                else if (brakets_in[i] == ')')
                {
                    temp = mystack.Pop();
                    if (temp == default(char))
                    {
                        Console.WriteLine("brakets are UNbalanced");
                        return false;
                    }
                }
            }
          
            if (mystack.count == 0)
            {
                Console.WriteLine("brakets are balanced");
                return true;
            }
            else
            {
                Console.WriteLine("brakets are UNbalanced");
                return false;
            }
        }

        public static void postfix(string input)
        {
            Stack<char> s1 = new Stack<char>();
            Stack<int> s2 = new Stack<int>();
            
            for (int i = (input.Length-1); i>=0; i--)
            {
                if (input[i] != ' ')
                    s1.Push(input[i]);
            }
            while(s1.count>0)
            {
                char temp;
                temp = s1.Pop();
                if (temp == '+')
                {
                    int sum = 0;
                    while (s2.count>0)
                    {
                        sum += s2.Pop();   
                    }
                    s2.Push(sum);
                }
                else if (temp == '*')
                {
                    int prod = 1;
                    while (s2.count > 0)
                    {
                        prod *= s2.Pop();
                    }
                    s2.Push(prod);
                }
                else if(temp== '=')
                {
                    Console.WriteLine("The answer is {0}", s2.Pop().ToString());
                }
                else
                {
                    int s = Convert.ToInt16( char.GetNumericValue(temp));
                    s2.Push(s);
                }
            }
        }
    }
}
