using System;
using System.Collections.Generic;


namespace AlgorithmsDataStructures2
{
    public static class BalancedBST2
    {
        public static int[] GenerateBBSTArray(int[] a)
        {
            if (a.Length > 1)
            {
                int lenght = Convert.ToInt32(Math.Pow(2, ((Math.Ceiling(Math.Log(a.Length) / Math.Log(2))))) - 1); //calculate the lenght
                int[] final = new int[lenght]; //build return array
                Array.Sort(a); //ascending sort
                Queue<Node> queue = new Queue<Node>();
                Node root = sortedArrayToBST(a, 0, a.Length - 1);
                int i = 1;
                queue.Enqueue(root);
                final[0] = root.data;
                while (queue.Count!=0)
                {
                    Node node = queue.Dequeue();
                    if (node.left != null)
                    {
                        final[i++] = node.left.data;
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        final[i++] = node.right.data;
                        queue.Enqueue(node.right);
                    }
                }
                return final;
            }
            else return null;
        }

        public static Node sortedArrayToBST(int[] arr, int start, int end)
        { 
            if (start > end)
            {
                return null;
            }
            int mid = (start + end) / 2;
            Node node = new Node(arr[mid]);
            node.left = sortedArrayToBST(arr, start, mid - 1);
            node.right = sortedArrayToBST(arr, mid + 1, end);
            return node;
        }
        public class Node
        {

            public int data;
            public Node left, right;

            public Node(int d)
            {
                data = d;
                left = right = null;
            }
        }
    }

}