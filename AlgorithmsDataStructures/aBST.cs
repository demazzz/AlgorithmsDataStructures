using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures2
{
    public class aBST
    {
        public int?[] Tree; // массив ключей

        public aBST(int depth)
        {
            // правильно рассчитайте размер массива для дерева глубины depth:
            int tree_size = Convert.ToInt32(Math.Pow(2,depth+1))-1;
            Tree = new int?[tree_size];
            for (int i = 0; i < tree_size; i++) Tree[i] = null;
        }

        public int? FindKeyIndex(int key)
        {
            // ищем в массиве индекс ключа
            
            { int i = 0;
                while(i<Tree.Length)
                { if (Tree[i] != null)
                    {
                        if (Tree[i] > key)
                            i = 2 * i + 1;
                        else if (Tree[i] < key)
                            i = 2 * i + 2;
                        else return i;
                    }
                    else
                    {
                        i = i * -1;
                        return i;
                    }
                }
            }
            return null; // не найден
        }

        public int AddKey(int key)
        {
            // добавляем ключ в массив

            //while(Tree[i]!=null)
            //{
            //    if (Tree[i] > key)
            //        i = 2 * i +1;
            //    else
            //        i = 2 * i + 2;
            //}
            int? k = FindKeyIndex(key);
            if (k != null)
            {
                int i = Convert.ToInt32(k);
                if (i < 0 && i < Tree.Length)
                {
                    i = i * -1;
                    Tree[i] = key;
                    
                }
                if (i==0)
                {
                    Tree[i] = key;
                }
                return Convert.ToInt32(i);
            }
            else
                return -1;
            // индекс добавленного/существующего ключа или -1 если не удалось
        }

    }
}