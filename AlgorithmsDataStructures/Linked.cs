using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class Node
    {
        public int value;
        public Node next;
        public Node(int _value) { value = _value; }
    }

    public class LinkedList
    {
        public Node head;
        public Node tail;

        public LinkedList()
        {
            head = null;
            tail = null;
        }

        public void AddInTail(Node _item)
        {
            if (head == null) head = _item;
            else tail.next = _item;
            tail = _item;
        }

        public Node Find(int _value)
        {
            Node node = head;
            while (node != null)
            {
                if (node.value == _value) return node;
                node = node.next;
            }
            return null;
        }

        public List<Node> FindAll(int _value)
        {
            // здесь будет ваш код поиска всех узлов по заданному значению
            List<Node> nodes = new List<Node>();
            if (head == null) return nodes;
            else
            {
                
                Node node = head;
                while (node != null)
                {
                    if (node.value == _value) nodes.Add(node);
                    node = node.next;
                }
                return nodes;
            }

        }

        public bool Remove(int _value)
        {
            Node prevnode = null;
            Node node = head;
            while (node != null)
            {
                if (node.value == _value)
                {
                    if (prevnode != null)
                    {
                        prevnode.next = node.next;

                        if (node.next == null)
                        {
                            tail = prevnode;
                        }
                    }
                    else
                    {
                        head = head.next;
                        if (head == null)
                        {
                            tail = null;
                        }
                    }
                    return true;
                }
                prevnode = node;
                node = node.next;
            }
            return false;
        }

        public void RemoveAll(int _value)
        {
            Node previous = null;
            Node current = head;
            while (current != null)
            {
                if (current.value == _value)
                {
                    if (previous != null)
                    {
                        previous.next = current.next;
                        if (current.next == null)
                        {
                            tail = previous;
                            current = current.next;
                        }
                        else current = current.next; 
                    }
                    else
                    {

                        if (current.next == null)
                        {
                            head = null;
                            tail = null;
                        }
                        else if (head == null || current.next == null)
                        {
                            tail = null;
                        }
                        else head = current.next;
                        current = head;
                    }
                }
                else
                {
                    previous = current;
                    current = current.next;
                }
            }
        }

        public void Clear()
        {
            // здесь будет ваш код очистки всего списка
            head = tail = null;
        }

        public int Count()
        {
            // здесь будет ваш код подсчёта количества элементов в списке
            if (head == null) return 0;
            else if (head == tail) return 1;
            else
            {
                Node node = head;
                int count = 0;
                while (node != null)
                {
                    count++;
                    node = node.next;
                }
                return count;
            }
        }

        public void InsertAfter(Node _nodeAfter, Node _nodeToInsert)
        {
            // здесь будет ваш код вставки узла после заданного
            // если _nodeAfter = null и список пустой, 
            // добавьте новый элемент первым в списке 
            if (_nodeToInsert == null) return;
            if (_nodeAfter == null && head == null)
                AddInTail(_nodeToInsert);
            else if (_nodeAfter == null)
            {
                Node _temp = head;
                head = _nodeToInsert;
                head.next = _temp;
            }

            else
            {
                if (head == tail)
                {
                    AddInTail(_nodeToInsert);
                }
                else
                {
                    Node node = head;
                    while (node != null)
                    {
                        if (node == _nodeAfter)
                        {
                            if (node.next == null)
                            {
                                Node _temp1 = node.next;
                                node.next = _nodeToInsert;
                                node.next.next = _temp1;
                                tail = _nodeToInsert;
                                return;
                            }
                            Node _temp = node.next;
                            node.next = _nodeToInsert;
                            node.next.next = _temp;
                        }
                        node = node.next;
                    }
                }
            }
        }


    }
}