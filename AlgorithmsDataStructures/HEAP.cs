using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures2
{
    public class Heap
    {

        public int[] HeapArray; // хранит неотрицательные числа-ключи
        public int HeapSize;
        int maxSize;
        public Heap() { HeapArray = null; }

        public void MakeHeap(int[] a, int depth)
        {
            //создаём массив кучи HeapArray из заданного
            // размер массива выбираем на основе глубины depth
            // ...
            //int lenght = Convert.ToInt32(Math.Pow(2, ((Math.Ceiling(Math.Log(depth) / Math.Log(2))))) - 1); //calculate the lenght


            maxSize = Convert.ToInt32( Math.Pow(2,depth)-1);
            HeapArray = new int[maxSize];
            HeapSize = 0;
            //for (int i = 0; i < HeapArray.Length; i++)
            //    HeapArray[i] = -65000;
            foreach (int item in a)
            {
                Add(item);
            }

           

        }

        public int GetMax()
        {
            // вернуть значение корня и перестроить кучу

            if (HeapArray.Length > 0)
                {

                    return HeapArray[0];
                }
            else
            return -1; // если куча пуста
        }

        private bool checkIfFull()
            {
            //for (int i=0; i<HeapArray.Length;i++)
            //if (HeapArray[i]==-65000) return true;
            //return false;

            if (HeapSize < maxSize) return true;
            else return false;
            }

        public bool Add(int key)
        {
            // добавляем новый элемент key в кучу и перестраиваем её
            if (checkIfFull())//check is there are any free space
            {
                HeapArray[HeapSize] = key;
                int i = HeapSize - 1;
                int parent = (i - 1) / 2;

                while (i > 0 && HeapArray[parent] < HeapArray[i])
                {
                    int temp = HeapArray[i];
                    HeapArray[i] = HeapArray[parent];
                    HeapArray[parent] = temp;
                    i = parent;
                    parent = (i - 1) / 2;
                }
                for (int i1 = maxSize / 2; i1 >= 0; i1--)
                {
                    heapify(i1);
                }
                HeapSize++;
                return true;
            }
            else //all cells are occupied
                return false;
        // если куча вся заполнена
        }

        private void heapify(int i)
        {
            int leftChild;
            int rightChild;
            int largestChild;

            for (; ; )
            {
                leftChild = 2 * i + 1;
                rightChild = 2 * i + 2;
                largestChild = i;

                if (leftChild < HeapArray.Length && HeapArray[leftChild] > HeapArray[largestChild])
                {
                    largestChild = leftChild;
                }

                if (rightChild < HeapArray.Length && HeapArray[rightChild] > HeapArray[largestChild])
                {
                    largestChild = rightChild;
                }

                if (largestChild == i)
                {
                    break;
                }

                int temp = HeapArray[i];
                HeapArray[i] = HeapArray[largestChild];
                HeapArray[largestChild] = temp;
                i = largestChild;
            }
        }


    }
    
    
}

