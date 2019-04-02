using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using AlgorithmsDataStructures2;



namespace AlgorithmsDataStructures
{
    class Program
    {
        static void Main(string[] args)
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
            Console.ReadLine();
        }
    }

}
