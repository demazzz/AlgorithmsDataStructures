using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures2.Tests
{
    [TestClass()]
    public class HeapTests
    {
        [TestMethod()]
        public void HeapTest()
        {
            int[] arr = { 1, 3, 5, 4, 6, 13, 10, 9, 8, 15, 17 };
            int n = arr.Length;
            Heap heap = new Heap();
            heap.MakeHeap(arr, 4);

            if (heap.GetMax() != 17) Assert.Fail();
            heap.Add(20);
            if (heap.GetMax() != 20) Assert.Fail();
            if (heap.HeapSize != 12) Assert.Fail();
            heap.Add(25);
            heap.Add(124);
            if (heap.GetMax() != 124) Assert.Fail();
            heap.Add(2);
            heap.Add(7);
            heap.Add(244);
            if (heap.GetMax() != 124) Assert.Fail();
            if (heap.HeapSize != 15) Assert.Fail();
        }

        [TestMethod()]
        public void MakeHeap()
        {
            int[] arr = { };
            Heap heap = new Heap();
            heap.MakeHeap(arr, 2);
            if (heap.HeapArray[0] != 0) Assert.Fail();
            Heap heap1 = new Heap();
            int[] arr1 = {1,2,3,4 };
            heap1.MakeHeap(arr1, 0);
            if (heap1.HeapArray != null) Assert.Fail();
            heap1.MakeHeap(arr1, -1);
            if (heap1.HeapArray != null) Assert.Fail();
            heap1.MakeHeap(arr1, 1);
            if (heap1.HeapArray.Length != 1) Assert.Fail();
            heap1.MakeHeap(arr1, 2);
            if (heap1.HeapArray.Length != 3) Assert.Fail();
            
            Heap heap2 = new Heap();
            heap2.MakeHeap(null, 0);
            if (heap2.HeapArray != null) Assert.Fail();

            Heap heap3 = new Heap();
            heap3.MakeHeap(null, 2);
            if (heap2.HeapArray != null) Assert.Fail();
        }

    }
}