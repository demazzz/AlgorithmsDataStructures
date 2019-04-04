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
    public class BSTTests
    {
        [TestMethod()]
        public void BSTTest()
        {

            BSTNode<int> A = new BSTNode<int>(8, 8, null);
            BSTNode<int> B = new BSTNode<int>(4, 4, null);
            BSTNode<int> C = new BSTNode<int>(12, 12, null);
            BSTNode<int> D = new BSTNode<int>(2, 2, null);
            BSTNode<int> F = new BSTNode<int>(6, 6, null);
            BSTNode<int> G = new BSTNode<int>(10, 10, null);
            BSTNode<int> H = new BSTNode<int>(14, 14, null);
            BSTNode<int> I = new BSTNode<int>(1, 1, null);
            BSTNode<int> J = new BSTNode<int>(3, 3, null);
            BSTNode<int> K = new BSTNode<int>(5, 5, null);
            BSTNode<int> L = new BSTNode<int>(7, 7, null);
            BSTNode<int> M = new BSTNode<int>(9, 9, null);
            BSTNode<int> N = new BSTNode<int>(11, 11, null);
            BSTNode<int> O = new BSTNode<int>(13, 13, null);
            BSTNode<int> P = new BSTNode<int>(15, 15, null);
            BST<int> tree = new BST<int>(A);
            tree.AddKeyValue(B.NodeKey, B.NodeValue);
            tree.AddKeyValue(C.NodeKey, C.NodeValue);
            tree.AddKeyValue(D.NodeKey, D.NodeValue);
            tree.AddKeyValue(F.NodeKey, F.NodeValue);
            tree.AddKeyValue(G.NodeKey, G.NodeValue);
            tree.AddKeyValue(H.NodeKey, H.NodeValue);
            tree.AddKeyValue(I.NodeKey, I.NodeValue);
            tree.AddKeyValue(J.NodeKey, J.NodeValue);
            tree.AddKeyValue(K.NodeKey, K.NodeValue);
            tree.AddKeyValue(L.NodeKey, L.NodeValue);
            tree.AddKeyValue(M.NodeKey, M.NodeValue);
            tree.AddKeyValue(N.NodeKey, N.NodeValue);
            tree.AddKeyValue(O.NodeKey, O.NodeValue);
            tree.AddKeyValue(P.NodeKey, P.NodeValue);
            BSTNode<int> exp1 = A.LeftChild.LeftChild.LeftChild;
            BSTNode<int> exp15 = A.RightChild.RightChild.RightChild;
            BSTNode<int> exp13 = A.RightChild.RightChild.LeftChild;
            BSTNode<int> exp11 = A.RightChild.LeftChild.RightChild;
            BSTNode<int> exp9 = A.RightChild.LeftChild.LeftChild;
            BSTNode<int> exp7 = A.LeftChild.RightChild.RightChild;
            BSTNode<int> exp5 = A.LeftChild.RightChild.LeftChild;
            BSTNode<int> exp3 = A.LeftChild.LeftChild.RightChild;
            BSTNode<int> exp2 = A.LeftChild.LeftChild;
            BSTNode<int> exp6 = A.LeftChild.RightChild;
            BSTNode<int> exp10 = A.RightChild.LeftChild;
            BSTNode<int> exp14 = A.RightChild.RightChild;
            BSTNode<int> exp12 = A.RightChild;
            BSTNode<int> exp4 = A.LeftChild;
            if (exp1.NodeKey != 1) Assert.Fail();
            if (exp2.NodeKey != 2) Assert.Fail();
            if (exp3.NodeKey != 3) Assert.Fail();
            if (exp4.NodeKey != 4) Assert.Fail();
            if (exp5.NodeKey != 5) Assert.Fail();
            if (exp6.NodeKey != 6) Assert.Fail();
            if (exp7.NodeKey != 7) Assert.Fail();
            if (exp9.NodeKey != 9) Assert.Fail();
            if (exp10.NodeKey != 10) Assert.Fail();
            if (exp11.NodeKey != 11) Assert.Fail();
            if (exp12.NodeKey != 12) Assert.Fail();
            if (exp13.NodeKey != 13) Assert.Fail();
            if (exp14.NodeKey != 14) Assert.Fail();
            if (exp15.NodeKey != 15) Assert.Fail();

            if (exp9.NodeKey != 9) Assert.Fail();
        }

        //[TestMethod()]
        //public void FindNodeByKeyTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void AddKeyValueTest()
        //{
        //    Assert.Fail();
        //}

        [TestMethod()]
        public void FinMinMaxTest()
        {
            BSTNode<int> A = new BSTNode<int>(8, 8, null);
            BSTNode<int> B = new BSTNode<int>(4, 4, A);
            BSTNode<int> C = new BSTNode<int>(12, 12, A);
            BSTNode<int> D = new BSTNode<int>(2, 2, B);
            BSTNode<int> F = new BSTNode<int>(6, 6, B);
            BSTNode<int> G = new BSTNode<int>(10, 10, C);
            BSTNode<int> H = new BSTNode<int>(14, 14, C);
            BSTNode<int> I = new BSTNode<int>(1, 1, D);
            BSTNode<int> J = new BSTNode<int>(3, 3, D);
            BSTNode<int> K = new BSTNode<int>(5, 5, F);
            BSTNode<int> L = new BSTNode<int>(7, 7, F);
            BSTNode<int> M = new BSTNode<int>(9, 9, G);
            BSTNode<int> N = new BSTNode<int>(11, 11, G);
            BSTNode<int> O = new BSTNode<int>(13, 13, H);
            BSTNode<int> P = new BSTNode<int>(15, 15, H);
            BST<int> tree = new BST<int>(A);
            tree.AddKeyValue(B.NodeKey, B.NodeValue);
            tree.AddKeyValue(C.NodeKey, C.NodeValue);
            tree.AddKeyValue(D.NodeKey, D.NodeValue);
            tree.AddKeyValue(F.NodeKey, F.NodeValue);
            tree.AddKeyValue(G.NodeKey, G.NodeValue);
            tree.AddKeyValue(H.NodeKey, H.NodeValue);
            tree.AddKeyValue(I.NodeKey, I.NodeValue);
            tree.AddKeyValue(J.NodeKey, J.NodeValue);
            tree.AddKeyValue(K.NodeKey, K.NodeValue);
            tree.AddKeyValue(L.NodeKey, L.NodeValue);
            tree.AddKeyValue(M.NodeKey, M.NodeValue);
            tree.AddKeyValue(N.NodeKey, N.NodeValue);
            tree.AddKeyValue(O.NodeKey, O.NodeValue);
            tree.AddKeyValue(P.NodeKey, P.NodeValue);
            int c1 = tree.Count();
            if (c1 != 15) Assert.Fail();
            B = tree.FindNodeByKey(B.NodeKey).Node;
            C = tree.FindNodeByKey(C.NodeKey).Node;
            D = tree.FindNodeByKey(D.NodeKey).Node;
            F = tree.FindNodeByKey(F.NodeKey).Node;
            G = tree.FindNodeByKey(G.NodeKey).Node;
            H = tree.FindNodeByKey(H.NodeKey).Node;
            I = tree.FindNodeByKey(I.NodeKey).Node;
            J = tree.FindNodeByKey(J.NodeKey).Node;
            K = tree.FindNodeByKey(K.NodeKey).Node;
            L = tree.FindNodeByKey(L.NodeKey).Node;
            M = tree.FindNodeByKey(M.NodeKey).Node;
            N = tree.FindNodeByKey(N.NodeKey).Node;
            O = tree.FindNodeByKey(O.NodeKey).Node;
            P = tree.FindNodeByKey(P.NodeKey).Node;
            
            BSTNode<int> Max = tree.FinMinMax(A, true);
            BSTNode<int> Min9 = tree.FinMinMax(C, false); //тут передаётся просто Нода со значением 12, у неё нет "дочерних" НОД
            BSTNode<int> Min = tree.FinMinMax(A, false);
            BSTNode<int> Min13 = tree.FinMinMax(O, false);
            if (Max.NodeKey != 15) Assert.Fail();
            if (Min.NodeKey!= 1) Assert.Fail();
            if (Min9.NodeKey != 9) Assert.Fail();
            if (Min13.NodeKey != 13) Assert.Fail();

        }

        [TestMethod()]
        public void DeleteNodeByKeyTest()
        {
            BSTNode<int> A = new BSTNode<int>(8, 8, null);
            BSTNode<int> B = new BSTNode<int>(4, 4, A);
            BSTNode<int> C = new BSTNode<int>(12, 12, A);
            BSTNode<int> D = new BSTNode<int>(2, 2, B);
            BSTNode<int> F = new BSTNode<int>(6, 6, B);
            BSTNode<int> G = new BSTNode<int>(10, 10, C);
            BSTNode<int> H = new BSTNode<int>(14, 14, C);
            BSTNode<int> I = new BSTNode<int>(1, 1, D);
            BSTNode<int> J = new BSTNode<int>(3, 3, D);
            BSTNode<int> K = new BSTNode<int>(5, 5, F);
            BSTNode<int> L = new BSTNode<int>(7, 7, F);
            BSTNode<int> M = new BSTNode<int>(9, 9, G);
            BSTNode<int> N = new BSTNode<int>(11, 11, G);
            BSTNode<int> O = new BSTNode<int>(13, 13, H);
            BSTNode<int> P = new BSTNode<int>(15, 15, H);
            BST<int> tree = new BST<int>(A);
            tree.AddKeyValue(B.NodeKey, B.NodeValue);
            tree.AddKeyValue(C.NodeKey, C.NodeValue);
            tree.AddKeyValue(D.NodeKey, D.NodeValue);
            tree.AddKeyValue(F.NodeKey, F.NodeValue);
            tree.AddKeyValue(G.NodeKey, G.NodeValue);
            tree.AddKeyValue(H.NodeKey, H.NodeValue);
            //tree.AddKeyValue(I.NodeKey, I.NodeValue);
            tree.AddKeyValue(J.NodeKey, J.NodeValue);
            tree.AddKeyValue(K.NodeKey, K.NodeValue);
            tree.AddKeyValue(L.NodeKey, L.NodeValue);
            tree.AddKeyValue(M.NodeKey, M.NodeValue);
            tree.AddKeyValue(N.NodeKey, N.NodeValue);
            tree.AddKeyValue(O.NodeKey, O.NodeValue);
            tree.AddKeyValue(P.NodeKey, P.NodeValue);
            if (tree.Count() != 14) Assert.Fail();
            B = tree.FindNodeByKey(B.NodeKey).Node;
            C = tree.FindNodeByKey(C.NodeKey).Node;
            D = tree.FindNodeByKey(D.NodeKey).Node;
            F = tree.FindNodeByKey(F.NodeKey).Node;
            G = tree.FindNodeByKey(G.NodeKey).Node;
            H = tree.FindNodeByKey(H.NodeKey).Node;
            I = tree.FindNodeByKey(I.NodeKey).Node;
            J = tree.FindNodeByKey(J.NodeKey).Node;
            K = tree.FindNodeByKey(K.NodeKey).Node;
            L = tree.FindNodeByKey(L.NodeKey).Node;
            M = tree.FindNodeByKey(M.NodeKey).Node;
            N = tree.FindNodeByKey(N.NodeKey).Node;
            O = tree.FindNodeByKey(O.NodeKey).Node;
            P = tree.FindNodeByKey(P.NodeKey).Node;
            tree.DeleteNodeByKey(D.NodeKey);
            if (A.LeftChild.LeftChild.NodeKey != 3) Assert.Fail();
            if (tree.Count() != 13) Assert.Fail();
            tree.DeleteNodeByKey(M.NodeKey);
            if (A.RightChild.LeftChild.LeftChild != null) Assert.Fail();
            tree.DeleteNodeByKey(C.NodeKey);
            if (tree.Count() != 11) Assert.Fail();
            if (A.RightChild.NodeKey != 13) Assert.Fail();
            tree.FindNodeByKey(12);

        }
    }
}