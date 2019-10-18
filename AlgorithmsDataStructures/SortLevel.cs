using System;
using System.Collections.Generic;

namespace SortSpace
{
    public static class SortLevel
    {
        public static int[] SelectionSortStep(int[] array, int i)
        {
            if (i < array.Length)
            {
                for (int j = i; j < i + 1; j++)
                {

                    int min = array[j];
                    int index = 0;
                    int temp = min;
                    for (int k = j; k < array.Length; k++)
                        if (min > array[k])
                        {

                            min = array[k];

                            index = k;
                        }
                    if (min != temp)
                    {
                        array[index] = temp;
                        array[j] = min;
                    }
                }
            }
            return array;
        }

        public static bool BubbleSortStep(int[] array )
        {
            int count = 0;
            for (int i=0; i<array.Length-1;i++)
            {
                if (array[i]>array[i+1])
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    count++;
                }
            }
            if (count == 0) return true;
            else return false;

        }
    }
}