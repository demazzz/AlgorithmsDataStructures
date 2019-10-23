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
    public class aBSTTests
    {
        [TestMethod()]
        public void aBSTTest()
        {
            aBST aBST = new aBST(3);
            if (aBST.AddKey(50)==-1) Assert.Fail();
            if (aBST.FindKeyIndex(50) != 0) Assert.Fail();
            if (aBST.AddKey(25) == -1) Assert.Fail();
            if (aBST.FindKeyIndex(25) != 1) Assert.Fail();
            if (aBST.AddKey(75) == -1) Assert.Fail();
            if (aBST.AddKey(37) == -1) Assert.Fail();
            if (aBST.AddKey(62) == -1) Assert.Fail();
            if (aBST.AddKey(84) == -1) Assert.Fail();
            if (aBST.AddKey(31) == -1) Assert.Fail();
            if (aBST.AddKey(43) == -1) Assert.Fail();
            if (aBST.AddKey(55) == -1) Assert.Fail();
            if (aBST.AddKey(92) == -1) Assert.Fail();
            if (aBST.Tree[3] != null) Assert.Fail();
            if (aBST.FindKeyIndex(92) != 14) Assert.Fail();
        }

        [TestMethod()]
        public void FindKeyIndexTest()
        {
            aBST aBST = new aBST(3);
            int[] ff = new int[10] { 25, 31, 37, 43, 50, 55, 62, 75, 84, 92 };
            foreach(int aa in ff)
            {
                aBST.AddKey(aa); 
            }
            if (aBST.FindKeyIndex(50) == -1) Assert.Fail();
        }

        [TestMethod()]
        public void AddKeyTest()
        {
           // Assert.Fail();
        }
    }
}