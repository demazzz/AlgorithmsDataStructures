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
    public class SimpleTreeTests
    {
        [TestMethod()]
        public void SimpleTreeTest()
        {
            SimpleTreeNode<string> a1 = new SimpleTreeNode<string>("a", null);
            SimpleTree<string> tree = new SimpleTree<string>(a1);
            tree.MoveNode(a1, a1);
            List<SimpleTreeNode<string>> aa = tree.GetAllNodes();
            int aaa = tree.Count();
            if (aaa != 1) Assert.Fail();
            int AA = tree.LeafCount();
            if (AA != 1) Assert.Fail();
            tree.DeleteNode(a1);
            int BB = tree.LeafCount();
            if (BB != 1) Assert.Fail();
            int bbb = tree.Count();
            if (bbb != 1) Assert.Fail();
            List<SimpleTreeNode<string>> aaaaaa = tree.FindNodesByValue("a");
            if (aaaaaa.Count != 1) Assert.Fail();
            List<SimpleTreeNode<string>> ab = tree.GetAllNodes();
            if (ab.Count != 1) Assert.Fail();
        }

        [TestMethod()]
        public void AddChildTest()
        {
            SimpleTreeNode<string> a1 = new SimpleTreeNode<string>("a", null);
            SimpleTreeNode<string> b1 = new SimpleTreeNode<string>("BA", a1);
            SimpleTreeNode<string> b2 = new SimpleTreeNode<string>("BB", a1);
            SimpleTreeNode<string> b3 = new SimpleTreeNode<string>("BC", a1);
            SimpleTreeNode<string> c2 = new SimpleTreeNode<string>("BA", null);
            SimpleTree<string> tree = new SimpleTree<string>(a1);
            //tree.AddChild(a1, b1);
            //tree.AddChild(a1, b2);
            //tree.AddChild(a1, b3);
            //tree.AddChild(b2, c2);
            //tree.MoveNode(b2, b1);
            //List<SimpleTreeNode<string>> aa = tree.GetAllNodes();
            //int aaa = tree.Count();
            //int AA = tree.LeafCount();
            ////tree.DeleteNode(b2);
            //int BB = tree.LeafCount();
            //int bbb = tree.Count();
            List<SimpleTreeNode<string>> aaaaaa = tree.FindNodesByValue("a");
            List<SimpleTreeNode<string>> ab = tree.GetAllNodes();
        }

        [TestMethod()]
        public void DeleteNodeTest()
        {
             SimpleTreeNode<string> a1 = new SimpleTreeNode<string>("a", null);
            SimpleTreeNode<string> b1 = new SimpleTreeNode<string>("BA", a1);
            SimpleTreeNode<string> b2 = new SimpleTreeNode<string>("BB", a1);
            SimpleTreeNode<string> b3 = new SimpleTreeNode<string>("BC", a1);
            SimpleTreeNode<string> b4 = new SimpleTreeNode<string>("BC", a1);
            SimpleTreeNode<string> c2 = new SimpleTreeNode<string>("CA", null);
            SimpleTree<string> tree = new SimpleTree<string>(a1);
            tree.AddChild(a1, b1);
            tree.AddChild(a1, b2);
            tree.AddChild(a1, b3);
            tree.AddChild(a1, b4);
            tree.AddChild(b2, c2);
            int A0 = tree.LeafCount();
            if (A0 != 4) Assert.Fail();
            int a0 = tree.Count();
            if (a0 != 6) Assert.Fail();
            tree.MoveNode(b2, b1);
            List<SimpleTreeNode<string>> aa = tree.GetAllNodes();
            int aaa = tree.Count();
            if (aaa != 6) Assert.Fail();
            int AA = tree.LeafCount();
            if (AA != 3) Assert.Fail();
            tree.DeleteNode(b2);
            int BB = tree.LeafCount();
            if (BB != 3) Assert.Fail();
            int bbb = tree.Count();
            if (bbb != 4) Assert.Fail();
            tree.DeleteNode(b3);
            int cc = tree.LeafCount();
            if (cc != 2) Assert.Fail();
            int CCC = tree.Count();
            if (CCC != 3) Assert.Fail();

            List<SimpleTreeNode<string>> aaaaaa = tree.FindNodesByValue("a");
            List<SimpleTreeNode<string>> ab = tree.GetAllNodes();
        }

        [TestMethod()]
        public void GetAllNodesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void FindNodesByValueTest()
        {
            SimpleTreeNode<string> a1 = new SimpleTreeNode<string>("a", null);
            SimpleTree<string> tree = new SimpleTree<string>(a1);
            List<SimpleTreeNode<string>> aaaaaa = tree.FindNodesByValue("a");
            List<SimpleTreeNode<string>> ab = tree.GetAllNodes();
            if (aaaaaa.Count != 1) Assert.Fail();
            if (ab.Count != 1) Assert.Fail();
        }

        [TestMethod()]
        public void MoveNodeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CountTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void LeafCountTest()
        {
            Assert.Fail();
        }
    }
}