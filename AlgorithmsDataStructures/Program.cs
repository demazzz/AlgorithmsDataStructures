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

            SimpleTreeNode<string> a1 = new SimpleTreeNode<string>("a", null);
            SimpleTreeNode<string> b1 = new SimpleTreeNode<string>("BA", a1);
            SimpleTreeNode<string> b2 = new SimpleTreeNode<string>("BB", a1);
            SimpleTreeNode<string> b3 = new SimpleTreeNode<string>("BC", a1);
            SimpleTreeNode<string> c2 = new SimpleTreeNode<string>("BA", null);
            SimpleTree<string> tree = new SimpleTree<string>(a1);
            tree.AddChild(a1, b1);
            tree.AddChild(a1, b2);
            tree.AddChild(a1, b3);
            tree.AddChild(b2, c2);
            tree.MoveNode(b2, b1);
            List<SimpleTreeNode<string>> aa = tree.GetAllNodes();
            int aaa = tree.Count();
            int AA = tree.LeafCount();
            tree.DeleteNode(b2);
            int BB = tree.LeafCount();
            int bbb = tree.Count();
            List<SimpleTreeNode<string>> aaaaaa = tree.FindNodesByValue("a");
            List<SimpleTreeNode<string>> ab = tree.GetAllNodes();
            Console.ReadLine();
        }
    }

}
