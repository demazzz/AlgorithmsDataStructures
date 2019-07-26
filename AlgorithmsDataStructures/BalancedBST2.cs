using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures2
{
    public class BSTNode
    {
        public int NodeKey; // ключ узла
        public BSTNode Parent; // родитель или null для корня
        public BSTNode LeftChild; // левый потомок
        public BSTNode RightChild; // правый потомок	
        public int Level; // глубина узла

        public BSTNode(int key, BSTNode parent)
        {
            NodeKey = key;
            Parent = parent;
            LeftChild = null;
            RightChild = null;
        }
    }

    public class BalancedBST
    {
        public BSTNode Root;

        public int[] BSTArray; // временный массив для ключей дерева

        public BalancedBST()
        {
            Root = null;
        }

        public void CreateFromArray(int[] a)
        {
            // создаём массив дерева BSTArray из заданного
            // ...
                Array.Sort(a); //ascending sort
            int lenght = Convert.ToInt32(Math.Pow(2, ((Math.Ceiling(Math.Log(a.Length) / Math.Log(2))))) - 1); //calculate the lenght
            BSTArray = new int[lenght];
            Queue<int[]> queue = new Queue<int[]>();
                queue.Enqueue(a);
                int i = 0;
             while (queue.Count > 0)
            {
                {
                    int[] temp = new int[a.Length];
                    if (queue.Count > 0)
                    {
                        temp = queue.Dequeue();
                        int tempint = 0;
                        
                        if (temp.Length > 1)
                        {
                            tempint = temp[(temp.Length) / 2];
                        }

                        else if (temp.Length==1)
                            tempint = temp[0];

                        int tempindex = Array.IndexOf(temp, tempint);
                        if (i < lenght)
                        {
                            BSTArray[i++] = Convert.ToInt32(tempint);
                            if (temp.Length > 2)
                            {
                                queue.Enqueue(Slice(temp, 0, tempindex));
                                queue.Enqueue(Slice(temp, tempindex+1, temp.Length));
                            }
                            else if (temp.Length==2)
                            {
                                queue.Enqueue(new int[] { temp[0] });
                               
                            }
                        }
                        
                    }
                    }
                }
            }
        

        private static int[] Slice(int[] source, int start, int end)
        {
            // Handles negative ends.
            if (end <= 0)
            {
                end = 1;
            }
            int len = end - start;

            // Return new array.
            int[] res = new int[len];
            for (int i = 0; i < len; i++)
            {
                res[i] = source[i + start];
            }
            return res;
        }

        public void GenerateTree()
        {
            // создаём дерево с нуля из массива BSTArray
            // ...
            if (BSTArray.Length > 0)
            {
                Queue<BSTNode> queue = new Queue<BSTNode>();
                Root = new BSTNode (BSTArray[0],null);
                Root.Level = 1;
                Queue<BSTNode> bSTNodes = new Queue<BSTNode>();
                bSTNodes.Enqueue(Root);
                int i = 1;
                while(bSTNodes.Count>0)
                {
                    if (i < BSTArray.Length)
                    {
                        BSTNode temp;
                        temp = bSTNodes.Dequeue();
                        temp.LeftChild = new BSTNode(BSTArray[i++], temp);
                        temp.LeftChild.Level = temp.Level +1;
                        bSTNodes.Enqueue(temp.LeftChild);
                        temp.RightChild = new BSTNode(BSTArray[i++], temp);
                        temp.RightChild.Level = temp.Level +1;
                        bSTNodes.Enqueue(temp.RightChild);
                    }
                    else bSTNodes = new Queue<BSTNode>();
                }
            }
            else return;
        }

        public bool IsBalanced(BSTNode root_node)
        {
            if (root_node == null) return true;
            if (root_node.LeftChild!=null && root_node.RightChild!=null)
            {
                if (root_node.LeftChild.NodeKey==0 && root_node.RightChild.NodeKey==0)
                {
                    return true;
                }
                else if (root_node.LeftChild.NodeKey <= root_node.RightChild.NodeKey && root_node.LeftChild.NodeKey < root_node.NodeKey && root_node.RightChild.NodeKey >= root_node.NodeKey)
                    {
                        int lh = height(root_node.LeftChild);
                        int rh = height(root_node.RightChild);
                        if (Math.Abs(lh - rh) <= 1 && IsBalanced(root_node.LeftChild)
                                    && IsBalanced(root_node.RightChild))
                        {
                            return true;
                        }
                    }
                        
            }
            else if (root_node.LeftChild!=null && root_node.RightChild==null)
            {
                if (root_node.LeftChild.NodeKey < root_node.NodeKey)
                {
                    int lh = height(root_node.LeftChild);
                    int rh = height(root_node.RightChild);
                    if (Math.Abs(lh - rh) <= 1 && IsBalanced(root_node.LeftChild)
                                && IsBalanced(root_node.RightChild))
                    {
                        return true;
                    }
                }
            }
            else if (root_node.RightChild != null && root_node.LeftChild == null)
            {
                if (root_node.RightChild.NodeKey >= root_node.NodeKey)
                {
                    int lh = height(root_node.LeftChild);
                    int rh = height(root_node.RightChild);
                    if (Math.Abs(lh - rh) <= 1 && IsBalanced(root_node.LeftChild)
                                && IsBalanced(root_node.RightChild))
                    {
                        return true;
                    }
                }
            }
            else if (root_node.RightChild==null && root_node.LeftChild==null)
            {
                return true;
            }
            return false; // сбалансировано ли дерево с корнем root_node
        }
        private int height(BSTNode node)
        {
            /* base case tree is empty */
            if (node == null)
            {
                return 0;
            }
            
            return 1 + Math.Max(height(node.LeftChild), height(node.RightChild));
        }
    }
}