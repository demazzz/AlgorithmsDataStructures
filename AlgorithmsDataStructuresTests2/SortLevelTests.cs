using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SortSpace.Tests
{
    [TestClass()]
    public class SortLevelTests
    {
        [TestMethod()]
        public void SelectionSortStepTest()
        {
            int[] arr = new int[] { 4, 3, 1, 2 };
            var arr1 = new int[] { 4, 3, 1, 2 };
            var arr2 = new int[] { 4, 3, 1, 2 };
            var arr3 = new int[] { 4, 3, 1, 2 };
            var opt0 = SortLevel.SelectionSortStep(arr, 0);
            Thread.Sleep(100);
            var opt1 = SortLevel.SelectionSortStep(arr1, 1);
            Thread.Sleep(100);
            var opt2 = SortLevel.SelectionSortStep(arr2, 2);
            Thread.Sleep(100);
            var opt3 = SortLevel.SelectionSortStep(arr3, 3);
            Thread.Sleep(100);
            if (!(opt0[0] == 1 && opt0[1] == 3 && opt0[2] == 4 && opt0[3] == 2)) Assert.Fail();
            if (!(opt1[0] == 4 && opt1[1] == 1 && opt1[2] == 3 && opt1[3] == 2)) Assert.Fail();
            if (!(opt2[0] == 4 && opt2[1] == 3 && opt2[2] == 1 && opt2[3] == 2)) Assert.Fail();
            if (!(opt3[0] == 4 && opt3[1] == 3 && opt3[2] == 1 && opt3[3] == 2)) Assert.Fail();

        }

        [TestMethod()]
        public void BubbleSortStepTest()
        {
            var arr = new int[] { 4, 3, 1, 2 };
            var raa = new int[] { 1, 2, 3, 4 };
            var arr1 = new int[] { 1, 2, 4, 3 };
            if (SortLevel.BubbleSortStep(arr) == true) Assert.Fail();
            if (SortLevel.BubbleSortStep(raa) == false) Assert.Fail();
            if (SortLevel.BubbleSortStep(arr1) == true) Assert.Fail();
        }

        [TestMethod()]
        public void InsertionSortStep()
        {
            var opt1 = new int[] { 7, 6, 5, 4, 3, 2, 1 };
            var etalon1 = new int[] { 1, 6, 5, 4, 3, 2, 7 };
            var etalon2 = new int[] { 1, 2, 3, 4 };
            var opt2 = new int[] { 4, 3, 2, 1 };
            var opt3 = new int[] { 1, 6, 5, 4, 3, 2, 7 };
            var etalon3 = new int[] { 1, 3, 5, 4, 6, 2, 7 };

            SortLevel.InsertionSortStep(opt2, 1, 0);
            SortLevel.InsertionSortStep(opt1, 3, 0);
            SortLevel.InsertionSortStep(opt3, 3, 1);

            for (int i = 0; i < opt1.Length; i++)
            {
                if (etalon1[i] != opt1[i]) Assert.Fail();
            }

            for (int i = 0; i < opt2.Length; i++)
            {
                if (etalon2[i] != opt2[i]) Assert.Fail();
            }
            for (int i = 0; i < opt3.Length; i++)
            {
                if (etalon3[i] != opt3[i]) Assert.Fail();
            }


        }

        [TestMethod()]
        public void ArrayChunkTest()
        {
            var opt = new int[] { 7, 5, 6, 4, 3, 1, 2 };
            
            var opt1 = new int[] {1};
            var opt2 = new int[] {1,2};
            var opt3 = new int[] { 9,5,8};
            var opt31 = new int[] { 1, 5, 8 };
            var opt4 = new int[] { 4,6,8,1};
            var opt5 = new int[] { 7, 5, 6, 4, 3, 1, 2 };

            int iii = SortLevel.ArrayChunk(opt);
            int iii1 = SortLevel.ArrayChunk(opt1);
            int iii2 = SortLevel.ArrayChunk(opt2);
            int iii21 = SortLevel.ArrayChunk(opt31);
            int iii3 = SortLevel.ArrayChunk(opt3);
            int iii4 = SortLevel.ArrayChunk(opt4);
            int iii5 = SortLevel.ArrayChunk(opt5);
            
            if (iii != 3) Assert.Fail();

            



        }
    }
}