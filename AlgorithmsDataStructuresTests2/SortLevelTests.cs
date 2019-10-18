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
            var raa = new int[] { 1,2,3,4 };
            var arr1 = new int[] { 1, 2, 4, 3 };
            if (SortLevel.BubbleSortStep(arr) == true) Assert.Fail();
            if (SortLevel.BubbleSortStep(raa) == false) Assert.Fail();
            if (SortLevel.BubbleSortStep(arr1) == true) Assert.Fail();
        }
    }
}