using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class Node
    {
        public int value;
        public Node next;
        public Node prev;
        public Node(int _value)
        {
            value = _value;
            next = null;
            prev = null;
         }
    }

    public class LinkedList2
    {
        public Node head;
        public Node tail;

        public LinkedList2()
        {
            head = null;
            tail = null;
        }

        public void AddInTail(Node _item)
        {
            if (head == null)
            {
                head = _item;
                _item.next = null;
                _item.prev = null;
            }
            else
            {
                tail.next = _item;
                _item.prev = tail;
             }
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
            if (head != null) 
           {
                Node node = head;
                while (node != null)
                {
                    if (node.value == _value) nodes.Add(node);
                    node = node.next;
                }    
            }
            return nodes;
        }

        public bool Remove(int _value)
        {
            Node prevnode = null;
            Node node = head;
            
            while (node != null)
            {
                if (head == null)
                {
                    tail = null;
                }
                if (node.value == _value)
                {
                    //узел в середине
                    if (prevnode != null)
                    {
                        //было 1 2 3
                        //стало 1 3
                        prevnode.next = node.next; // 1 связали с 3
                        
                        //узел в конце
                        if (node.next == null)
                        {
                           tail = prevnode;//хвост делаем предыдущим 
                        }
                        //
                        else
                        {
                            node.next.prev = prevnode;
                        }
                    }
                    //узел в начале
                    else
                    {
                        if (node.next == null)
                        {
                            head = tail = null;
                        }

                        else
                        {
                            head = head.next;
                            head.prev = null;
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
                    //если находится не в начале
                    if (previous != null)
                    {
                        //было ..1 2 3..
                        //стало ..1 3..
                        previous.next = current.next;
                        
                        //если упёрлись в tail и дальше нуль
                        //было ..1 2 3 4
                        //стало ..1 2 3 
                        if (current.next == null)
                        {
                            tail = previous;
                            current = current.next;
                        }

                        else
                        {
                            previous.next.prev = previous;
                           
                            current = current.next;
                            
                        }
                    }
                    //находится в первом элементе - head
                    else
                    {
                        //если только один элемент
                        if (current.next == null)
                        {
                            head = null;
                            tail = null;
                            return;
                        }
                        //если голова ноль или дальше ноль. бред какой-то написал...
                        else if (head == null || current.next == null)
                        {
                            tail = null;
                        }
                        //если дальше есть значения и 
                        //было 1 2 3
                        //стало 2 3
                        else
                        {
                            head = current.next;
                            head.prev = null;
                            current = head;
                        }
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
            //случай если вставляем вначало
            else if (_nodeAfter == null)
            {
                Node _temp = head;
                head = _nodeToInsert;
                head.next = _temp;
                head.next.prev = _nodeToInsert;
            }
            //если вставляем в середину или конец
            else
            {
                //если вставляем в список из 1
                if (head == tail)
                {
                    AddInTail(_nodeToInsert);
                }
                //если список больше чем из 1 элемента
                else
                {
                    Node node = head;
                    while (node != null)
                    {
                        if (node == _nodeAfter)
                        {
                            //если вставляем в конец
                            //было 1 2 3
                            //стало 1 2 3 +5
                            if (node.next == null)
                            {
                                //Node _temp1 = node.next;
                                node.next = _nodeToInsert;
                                //node.next.next = _temp1;
                                node.next.prev = node;
                                tail = _nodeToInsert;
                                return;
                            }
                            //вставляем в середину
                            //было 1 2 3
                            //стало 1 2 ..5.. 3
                            else
                            {
                                Node _temp = node.next;
                                node.next = _nodeToInsert;
                                node.next.next = _temp;
                                node.next.prev = node;
                                node.next.next.prev = _nodeToInsert;
                            }
                        }
                        node = node.next;
                    }
                }
            }
        }


    }
}