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

            SimpleTreeNode<int> a1 = new SimpleTreeNode<int>(10, null);
            SimpleTreeNode<int> b1 = new SimpleTreeNode<int>(20, a1);
            SimpleTreeNode<int> b2 = new SimpleTreeNode<int>(21, a1);
            SimpleTreeNode<int> b3 = new SimpleTreeNode<int>(22, a1);
            SimpleTreeNode<int> c2 = new SimpleTreeNode<int>(32, null);
            SimpleTree<int> tree = new SimpleTree<int>(a1);
            //tree.AddChild(a1,new SimpleTreeNode<int>(20,a1));
            tree.AddChild(a1, b1);
            tree.AddChild(a1, b2);
            tree.AddChild(a1, b3);
            tree.AddChild(b2, c2);
            tree.MoveNode(c2, a1);
            List<SimpleTreeNode<int>> aa = tree.GetAllNodes();
            int aaa = tree.Count();
            int AA = tree.LeafCount();
            tree.DeleteNode(b2);
            int BB = tree.LeafCount();
            int bbb = tree.Count();
            List<SimpleTreeNode<int>> ab = tree.GetAllNodes();
            Console.ReadLine();
        }
    }

}
