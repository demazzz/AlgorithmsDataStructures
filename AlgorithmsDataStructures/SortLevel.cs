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

        public static bool BubbleSortStep(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
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

        //public static void InsertionSortStep(int[] array, int step, int i)
        //{
        //    for (int i1 = i + step; i1 < array.Length; i1 = i1 + step)
        //    {
        //        if (i1 == i + step && array[i1] < array[i])
        //        {
        //            int temp = array[i1 - step];
        //            array[i1 - step] = array[i1];
        //            array[i1] = temp;
        //        }
        //        else if (i1 > i + step)
        //        {

        //            int temp = array[i1];

        //            for (int j = i; j < i1; j += step)
        //            {
        //                int temp2 = array[j];
        //                if (temp < temp2 || ((j == i1 - step) && i1 != array.Length - 1))
        //                {
        //                    array[j] = temp;
        //                    temp = array[j + step];
        //                    array[j + step] = temp2;
        //                }
        //            }
        //        }
        //        //break;
        //    }
        //}
        public static void InsertionSortStep(int[] array, int step, int i)
        {
            for (int i1 = i + step; i1 < array.Length; i1 = i1 + step)
            {
                if (i1 == i + step && array[i] > array[i1])
                {
                    int temp = array[i1];
                    int temp2 = array[i];
                    array[i] = temp;
                    array[i1] = temp2;
                }
                else if (i1 > i + step)
                {
                    int temp = array[i1];
                    for (int j = i; j < i1; j += step)
                    {
                        int temp2 = array[j];
                        if (temp2 > temp)
                        {
                            array[j] = temp;
                            temp = temp2;
                            array[i1] = temp2;
                        }
                    }
                }
            }
        }
        public static List<int> KnuthSequence(int array_size)
        {
            int[] array;

            //N(i) = 3 * N(i - 1) + 1
            int i = 0;
            int step = 0;
            List<int> list = new List<int>
            {
                1
            };
            while (step < array_size)
            {
                step = 3 * list[i] + 1;
                if (step < array_size)
                    list.Add(step);
                i++;
            }

            list.Reverse();

            return list;
        }

        public static int ArrayChunk(ref int[] M)
        {
        begining:
            int l = M.Length;
            int N = M[l / 2];
            int i1 = 0;
            int i2 = l - 1;
            int pos = 0;
        MainItem:
            while (M[i1] < N)
            {
                i1++;
            }
            while (M[i2] > N)
            {
                 i2--;
            }
            if (l > 3)
            {
                if (i1 == i2 - 1 && M[i1] > M[i2])
                {
                    int temp = M[i2];
                    M[i2] = M[i1];
                    M[i1] = temp;
                    goto begining;
                }


                else if (i1 == i2 || (i1 == i2 - 1 && M[i1] < M[i2]))
                {
                    for (int i = 0; i < l; i++)
                    {
                        if (N == M[i])
                        {
                            pos = i;
                            goto ending;
                        }
                    }
                }
                else
                {
                    int temp = M[i1];
                    M[i1] = M[i2];
                    M[i2] = temp;

                    goto MainItem;
                }
            }
            else if (l == 3)
            {
                if (M[0] > M[2])
                {
                    int temp = M[2];
                    M[2] = M[0];
                    M[0] = temp;
                }
                if (M[0] > M[1])
                {
                    int temp = M[1];
                    M[1] = M[0];
                    M[0] = temp;
                }
                pos = 1;
                goto ending;
            }
            else if (l == 2)
            {
                if (M[1]<M[0])
                {
                    M[0] = M[1];
                }
                pos = l / 2;
                goto ending;
            }
            
            ending:
            return pos;

        }

        //public static void QuickSort(int[] array, int left =0, int right = -1)
        //{
        //    if (right < 0) right = array.Length - 1;
        //    if (left >= right)
        //        return;
        //    if (left==right)
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        int middleIndex = (right - left) / 2 + left, currentIndex = right;

        //        int N = ArrayChunk(ref array);
        //        if (N <= 0) return;
        //        QuickSort(array, left, N - 1);
        //        QuickSort(array, N + 1, right);
        //    }
        //}

        public static void QuickSort(int[] array, int left = 0, int right = -1)
        {
            if (right < 0)
                right = array.Length - 1;
            if (left >= right)
                return;
            int middleIndex = (right - left) / 2 + left, currentIndex = left;
            Swap(ref array[left], ref array[middleIndex]);
            for (int i = left + 1; i <= right; ++i)
            {
                if (array[i] <= array[left])
                {
                    Swap(ref array[++currentIndex], ref array[i]);
                }
            }
            Swap(ref array[left], ref array[currentIndex]);
            QuickSort(array, left, currentIndex - 1);
            QuickSort(array, currentIndex + 1, right);
        }
        static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

    }
}
