using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures2
{
    public class BSTNode<T>
    {
        public int NodeKey; // ключ узла
        public T NodeValue; // значение в узле
        public BSTNode<T> Parent; // родитель или null для корня
        public BSTNode<T> LeftChild; // левый потомок
        public BSTNode<T> RightChild; // правый потомок	

        public BSTNode(int key, T val, BSTNode<T> parent)
        {
            NodeKey = key;
            NodeValue = val;
            Parent = parent;
            LeftChild = null;
            RightChild = null;
        }
    }

    // промежуточный результат поиска
    public class BSTFind<T>
    {
        // null если не найден узел, и в дереве только один корень
        public BSTNode<T> Node;

        // true если узел найден
        public bool NodeHasKey;

        // true, если родительскому узлу надо добавить новый левым
        public bool ToLeft;

        public BSTFind() { Node = null; }
    }

    public class BST<T>
    {
        BSTNode<T> Root; // корень дерева, или null

        public BST(BSTNode<T> node)
        {
            Root = node;
        }

        public BSTFind<T> FindNodeByKey(int key)
        {
            // ищем в дереве узел и сопутствующую информацию по ключу
            
            BSTFind<T> found = new BSTFind<T>();
            BSTNode<T> Node = Root;
            if (Node.NodeKey == key && Node.LeftChild==null && Node.RightChild==null)
            {
                found.Node = null;
                found.NodeHasKey = true;
            }
            else
            {
               if (Node.LeftChild==null && Node.RightChild==null)
                {
                    if (key>Node.NodeKey)
                    {
                        found.Node = Node;
                        found.NodeHasKey = false;
                        found.ToLeft = false;
                    }
                    else
                    {
                        found.Node = Node;
                        found.NodeHasKey = false;
                        found.ToLeft = true;
                    }
                    return found;
                }
                while (Node.LeftChild != null || Node.RightChild != null)
                {
                    if (Node.LeftChild != null && Node.RightChild != null)
                    {
                        if (key == Node.NodeKey)
                        {
                            found.Node = Node;
                            found.NodeHasKey = true;
                            break;
                        }
                        else if (key > Node.NodeKey)
                        {
                            Node = Node.RightChild;
                        }
                        else
                        {
                            Node = Node.LeftChild;
                        }

                    }
                    else if (Node.LeftChild != null && Node.RightChild == null)
                    {
                        if (key == Node.NodeKey)
                        {
                            found.Node = Node;
                            found.NodeHasKey = true;
                            return found;
                        }
                        else if (key > Node.NodeKey)
                        {
                            found.Node = Node;
                            found.NodeHasKey = false;
                            found.ToLeft = false;
                            return found;
                        }
                        else
                        {
                            Node = Node.LeftChild;
                        }

                    }
                    else if (Node.LeftChild == null && Node.RightChild != null)
                    {
                        if (key == Node.NodeKey)
                        {
                            found.Node = Node;
                            found.NodeHasKey = true;
                            return found;
                        }
                        else if (key > Node.NodeKey)
                        {
                            Node = Node.RightChild;
                        }
                        else
                        {
                            found.Node = Node;
                            found.NodeHasKey = false;
                            found.ToLeft = true;
                            return found;
                        }
                    }

                }
                if (Node.LeftChild == null && Node.RightChild == null)
                {
                    if (key > Node.NodeKey)
                    {
                        found.Node = Node;
                        found.NodeHasKey = false;
                        found.ToLeft = false;
                    }
                    else
                    {
                        found.Node = Node;
                        found.NodeHasKey = false;
                        found.ToLeft = true;
                    }
                    return found;
                }
                else if (Node.LeftChild != null && Node.RightChild == null)
                {
                    if (key == Node.NodeKey)
                    {
                        found.Node = Node;
                        found.NodeHasKey = true;

                    }
                    else if (key > Node.NodeKey)
                    {
                        found.Node = Node;
                        found.NodeHasKey = false;
                        found.ToLeft = false;

                    }


                }
                else if (Node.LeftChild == null && Node.RightChild != null)
                {
                    if (key == Node.NodeKey)
                    {
                        found.Node = Node;
                        found.NodeHasKey = true;
                    }
                    else if (key > Node.NodeKey)
                    {

                    }
                    else
                    {
                        found.Node = Node;
                        found.NodeHasKey = false;
                        found.ToLeft = true;
                    }
                }



            }

            return found;
            
        }

        public bool AddKeyValue(int key, T val)
        {
            // добавляем ключ-значение в дерево
            BSTNode<T> Node = Root;
            BSTFind<T> FindNode = FindNodeByKey(key);
            if (FindNode.Node!= null)
            {
                if (FindNode.NodeHasKey==false)
                {
                    if(FindNode.ToLeft==true)
                    {
                        FindNode.Node.LeftChild = new BSTNode<T>(key, val, FindNode.Node);
                        return true;
                    }
                    else
                    {
                     FindNode.Node.RightChild = new BSTNode<T>(key, val, FindNode.Node);
                        return true;
                    }
                }
            }
           return false;
        }

        public BSTNode<T> FinMinMax(BSTNode<T> FromNode, bool FindMax)
        {
            // ищем максимальное/минимальное в поддереве
            BSTNode<T> Node = FromNode;
            if (FromNode == null) return null;
            if (FindMax == false)
            {
                if (Node.LeftChild != null)
                    while (Node.LeftChild != null)
                    {
                        Node = Node.LeftChild;
                    }
                return Node;
            }
            else
            {
                if (Node.RightChild != null)
                    while (Node.RightChild != null)
                    {
                        Node = Node.RightChild;
                    }
                return Node;
            }
            
        }


        public bool DeleteNodeByKey(int key)
        {
            // удаляем узел по ключу
            BSTNode<T> Node = FindNodeByKey(key).Node;
            if (Node != null)
            {
                if (Node.LeftChild==null && Node.RightChild== null)
                {  
                    {
                        if (key > Node.Parent.NodeKey)
                            Node.Parent.RightChild = null;
                        else
                            Node.Parent.LeftChild = null;
                    }
                    return true;
                }
                if (Node.LeftChild != null ^ Node.RightChild != null)
                {
                    if (Node.LeftChild != null)
                    {
                        if (key > Node.Parent.NodeKey)
                            Node.Parent.RightChild = Node.LeftChild;
                        else
                            Node.Parent.LeftChild = Node.LeftChild;
                        Node.LeftChild.Parent = Node.Parent;
                    }
                    else
                    {
                        if (key > Node.Parent.NodeKey)
                            Node.Parent.RightChild = Node.RightChild;
                        else
                            Node.Parent.LeftChild = Node.RightChild;
                        Node.RightChild.Parent = Node.Parent;

                    }
                    return true;
                }
                else if (Node.LeftChild != null && Node.RightChild != null)
                {
                    BSTNode<T> find = Node;
                    find = Node.RightChild;
                    if (find.LeftChild != null)
                    {
                        while (find.LeftChild != null)
                        {
                            find = find.LeftChild;
                        }
                        if (find.RightChild != null)
                        {
                            find = find.RightChild;
                        }
                        else
                        {
                            if (key > Node.Parent.NodeKey)
                            {
                                Node.Parent.RightChild = find;
                            }
                            else
                            {
                                Node.Parent.LeftChild = find;
                            }
                            Node.RightChild.Parent = find;
                            Node.LeftChild.Parent = find;
                            find.Parent.LeftChild = null;
                            find.Parent = Node.Parent;
                            find.LeftChild = Node.LeftChild;
                            find.RightChild = Node.RightChild;
                        }
                    }
                    else
                    {
                        find = find.RightChild;
                        Node.RightChild.Parent = find;
                        //Node.LeftChild.Parent = find;
                        find.Parent.LeftChild = null;
                        find.Parent = Node.Parent;
                        //find.LeftChild = Node.LeftChild;
                        find.RightChild = Node.RightChild;
                    }
                    return true;
                }
            }
            return false; // если узел не найден
        }

        public int Count()
        {
            if (Root != null)
            {
                int count = 1;
                Stack<BSTNode<T>> stack = new Stack<BSTNode<T>>();
                BSTNode<T> Node = Root;
                if (Node.LeftChild != null)
                    stack.Push(Node.LeftChild);
                if (Node.RightChild != null)
                    stack.Push(Node.RightChild);
                while(stack.Count!=0)
                {
                    Node = stack.Pop();
                    count++;
                    if (Node.LeftChild != null)
                        stack.Push(Node.LeftChild);
                    if (Node.RightChild != null)
                        stack.Push(Node.RightChild);
                }
                return count;
            }
            else
            return 0; // количество узлов в дереве
        }

        public List<BSTNode<T>> WideAllNodes()
        {
            List<BSTNode<T>> listnodes = new List<BSTNode<T>>();
            BSTNode<T> node;
            Queue<BSTNode<T>> q = new Queue<BSTNode<T>>();
            q.Enqueue(Root);
            while (q.Count!=0)
            {
                node = q.Dequeue();
                listnodes.Add(node);
                if (node.LeftChild!=null)
                {
                    q.Enqueue(node.LeftChild);
                }
                if (node.RightChild!=null)
                {
                    q.Enqueue(node.RightChild);
                }
            }
            return listnodes;
        }
      
        public List<BSTNode<T>> DeepAllNodes(int order)
        {
            List<BSTNode<T>> list = new List<BSTNode<T>>();

            if (order == 0)
            {
                inorder(Root, ref list);
            }
            else if (order==1)
            {
                postorder(Root, ref list);
            }
            else if (order==2)
            {
                preorder(Root, ref list);
            }
            
            else
            {
                return null;
            }
            return list;
        }

        private void inorder(BSTNode<T> Node, ref List<BSTNode<T>> List) //left-node-right
        {
            if (Node != null)
            {
                inorder(Node.LeftChild, ref List);
                List.Add(Node);
                inorder(Node.RightChild, ref List);
            }
        }
        
        private void postorder(BSTNode<T> Node, ref List<BSTNode<T>> List) //left-right-node
        {
            if (Node != null)
            {
                postorder(Node.LeftChild, ref List);
                postorder(Node.RightChild, ref List);
                List.Add(Node);
            }
        }
        private void preorder(BSTNode<T> Node, ref List<BSTNode<T>> List) //node-left-right
        {
            List.Add(Node);
            if (Node.LeftChild != null)
                preorder(Node.LeftChild, ref List);
            if (Node.RightChild != null)
                preorder(Node.RightChild, ref List);
        }
    }
}