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
    public class BalancedBSTTests
    {
        [TestMethod()]
        public void IsBalancedTest()
        {
            BalancedBST b1 = new BalancedBST();
            BSTNode a1 = new BSTNode(6, null);
            a1.Level = 1;
            if (!b1.IsBalanced(a1)) Assert.Fail();

            a1.LeftChild = new BSTNode(3, a1);
            a1.LeftChild.Level = a1.Level + 1;
            if (!b1.IsBalanced(a1)) Assert.Fail();

            a1.LeftChild.LeftChild = new BSTNode(2, a1.LeftChild);
            a1.LeftChild.LeftChild.Level = a1.Level + 2;
            if (b1.IsBalanced(a1)) Assert.Fail();

            a1.RightChild = new BSTNode(7, a1);
            a1.RightChild.Level = a1.Level + 1;
            if (!b1.IsBalanced(a1)) Assert.Fail();

            a1.RightChild.LeftChild = new BSTNode(10, a1.RightChild);
            a1.RightChild.LeftChild.Level = 3;
            if (b1.IsBalanced(a1)) Assert.Fail();
        }
    }
}