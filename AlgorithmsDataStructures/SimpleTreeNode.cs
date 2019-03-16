using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures2
{
    public class SimpleTreeNode<T>
    {
        public T NodeValue; // значение в узле
        public SimpleTreeNode<T> Parent; // родитель или null для корня
        public List<SimpleTreeNode<T>> Children; // список дочерних узлов или null

        public SimpleTreeNode(T val, SimpleTreeNode<T> parent)
        {
            NodeValue = val;
            Parent = parent;
            Children = null;
        }
    }

    public class SimpleTree<T>
    {
        public SimpleTreeNode<T> Root; // корень, может быть null

        public SimpleTree(SimpleTreeNode<T> root)
        {
            Root = root;
        }

        public void AddChild(SimpleTreeNode<T> ParentNode, SimpleTreeNode<T> NewChild)
        {
            // ваш код добавления нового дочернего узла существующему ParentNode
            if (ParentNode.Children == null)
            {
                ParentNode.Children = new List<SimpleTreeNode<T>>();
            }
            ParentNode.Children.Add(NewChild);
            NewChild.Parent = ParentNode;
        }

        public void DeleteNode(SimpleTreeNode<T> NodeToDelete)
        {
            // ваш код удаления существующего узла NodeToDelete
            
            if (NodeToDelete.Parent != null || NodeToDelete == null)
            {
                if (NodeToDelete.Children !=null)
                NodeToDelete.Parent.Children.Remove(NodeToDelete);
                NodeToDelete.Children = null;
                NodeToDelete.Parent = null;
            }
            else return;
        }

        public List<SimpleTreeNode<T>> GetAllNodes()
        {
            // ваш код выдачи всех узлов дерева в определённом порядке
            List<SimpleTreeNode<T>> returnList = new List<SimpleTreeNode<T>>();
            Stack<SimpleTreeNode<T>> stack = new Stack<SimpleTreeNode<T>>();
            SimpleTreeNode<T> Node = Root;
            stack.Push(Root);
            while (stack.Count > 0)
            {
                if (Node.Children != null)
                    foreach (SimpleTreeNode<T> node in Node.Children)
                    {
                    stack.Push(node);
                    }
                
                Node = stack.Pop();
                returnList.Add(Node);
            }
                return returnList;
        }

        public List<SimpleTreeNode<T>> FindNodesByValue(T val)
        {
            // ваш код поиска узлов по значению
            List<SimpleTreeNode<T>> returnList = new List<SimpleTreeNode<T>>();
            Stack<SimpleTreeNode<T>> stack = new Stack<SimpleTreeNode<T>>();
            SimpleTreeNode<T> Node = Root;
            stack.Push(Root);
            while (stack.Count > 0)
            {
                if (Node.Children != null)
                    foreach (SimpleTreeNode<T> node in Node.Children)
                    {
                        stack.Push(node);
                    }

                Node = stack.Pop();
                if (Comparer<T>.Default.Compare(Node.NodeValue, val) == 0)
                    
                returnList.Add(Node);
            }
            return returnList;;
        }

        public void MoveNode(SimpleTreeNode<T> OriginalNode, SimpleTreeNode<T> NewParent)
        {
            // ваш код перемещения узла вместе с его поддеревом -- 
            // в качестве дочернего для узла NewParent
            if (OriginalNode != NewParent)
            {
                SimpleTreeNode<T> node = OriginalNode;
                OriginalNode.Parent.Children.Remove(OriginalNode);
                AddChild(NewParent, node);
            }
             
        }

        public int Count()
        {
            // количество всех узлов в дереве
            int count = 0;
            Stack<SimpleTreeNode<T>> stack = new Stack<SimpleTreeNode<T>>();
            SimpleTreeNode<T> Node = Root;
            stack.Push(Root);
            while (stack.Count > 0)
            {
                if (Node.Children != null)
                    foreach (SimpleTreeNode<T> node in Node.Children)
                    {
                        stack.Push(node);
                    }
                Node = stack.Pop();
                count++;
            }
            return count;
        }

        public int LeafCount()
        {
            // количество всех узлов в дереве
            int count = 0;
            Stack<SimpleTreeNode<T>> stack = new Stack<SimpleTreeNode<T>>();
            SimpleTreeNode<T> Node = Root;
            stack.Push(Root);
            while (stack.Count > 0)
            {
                if (Node.Children != null)
                    foreach (SimpleTreeNode<T> node in Node.Children)
                    {
                        stack.Push(node);
                    }
                else { count++; }
                Node = stack.Pop();
                
            }
            return count;
        }

    }

}