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

        public static void InsertionSortStep(int[] array, int step, int i)
        {
            for (int i1 =i+step; i1 < array.Length; i1+=step)
            {
                if (i1 == i+step && array[i1] < array[i])
                {
                    int temp = array[i1-step];
                    array[i1-step] = array[i1];
                    array[i1] = temp;
                }
                else if (i1>i+step)
                {
                  
                    int temp = array[i1];
                   
                    for (int j = i; j < i1; j+=step)
                    {
                        int temp2 = array[j];

                        if (temp < temp2 || (j == i1-step) && i1!=array.Length-1)
                        {
                            array[j] = temp;
                            temp = array[j +step];
                            array[j + step] = temp2;
                        }
                    }
                }
            }
        }
        public static void InsertionSortStep(int[] array)
        {
            for (int i =1; i< array.Length;i++)
            {
                if (i==1 && array[i+1]<array[0])
                {
                    int temp = array[0];
                    array[0] = array[i+1];
                    array[i+1] = temp;
                }
                else
                {
                    int temp = array[i];
                    for (int j = 0; j<i;j++)
                    {
                        int temp2 = array[j];

                        if (temp<temp2 || j==i-1)
                        {
                            array[j] = temp;
                            temp = array[j + 1];
                            array[j + 1] = temp2;
                        }
                    }
                }
            }

        }

    }
}