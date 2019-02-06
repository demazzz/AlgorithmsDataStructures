﻿using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class Node<T>
    {
        public T value;
        public Node<T> next, prev;

        public Node(T _value)
        {
            value = _value;
            next = null;
            prev = null;
        }
    }

    public class OrderedList<T>
    {
        public Node<T> head, tail;
        private bool _ascending;

        public OrderedList(bool asc)
        {
            head = null;
            tail = null;
            _ascending = asc;
        }

        public int Compare(T v1, T v2)
        {
            int result = 0;
            if (typeof(T) == typeof(String))
            {
                // версия для лексикографического сравнения строк
                string s1 = v1.ToString();
                string s2 = v2.ToString();
                if (s1[0] == ' ') s1 = s1.TrimStart(' ');
                if (s1[s1.Length - 1] == ' ') s1 = s1.TrimStart(' ');
                if (s2[0] == ' ') s2 = s2.TrimStart(' ');
                if (s2[s2.Length - 1] == ' ') s2 = s2.TrimStart(' ');
                if (_ascending == true)
                {
                    if (string.Compare(s2, s1, StringComparison.InvariantCulture) < 0) result = -1;
                    else if (string.Compare(s2, s1, StringComparison.InvariantCulture) > 0) result = 1;
                    else result = 0;
                }
                else
                {
                    if (string.Compare(s1, s2, StringComparison.InvariantCulture) < 0) result = -1;
                    else if (string.Compare(s1, s2, StringComparison.InvariantCulture) > 0) result = 1;
                    else result = 0;

                }
            }
            else
            {
                // универсальное сравнение
                string s1 = v1.ToString();
                string s2 = v2.ToString();
                decimal d1 = Convert.ToDecimal(s1);
                decimal d2 = Convert.ToDecimal(s2);
                if (_ascending == true)
                    result = d2.CompareTo(d1);
                else
                    result = d1.CompareTo(d2);
            }

            return result;
        }

        public void Add(T value)
        {
            // автоматическая вставка value 
            // в нужную позицию
            // 1. вставка в пустой массив
            // 2. больше одного элемента
            //  2.1 число ставится в tail 
            //  2.2 число ставится в середину
            //  2.3 число ставится в head
            Node<T> newnode = new Node<T>(value);
            if (Count() > 0)
            {
                Node<T> node = head;
                int move = Compare(value, node.value);
                move = Compare(value, node.value);
                //случай 2
                //находим нужную ноду
                while (move <= 0 && node.next != null)
                {
                    node = node.next;
                    move = Compare(value, node.value);
                }
                //случай 2.2
                //было 1 2 4 5, вставляем 3
                if (move >= 0 && (node.next != null && node.prev != null))
                {
                    newnode.next = node;
                    newnode.prev = node.prev;
                    node.prev.next = newnode;
                    node.prev = newnode;

                }
                //случай 2.1
                //было 1 2 3, вставляем 4
                else if (move <= 0 && node.next == null)
                {
                    tail.next = newnode;
                    newnode.prev = node;
                    tail = newnode;

                }
                //2.3 
                //имеем 2 3 4, вставляем 1
                else if (move >= 0 && node.prev == null)
                {
                    head = newnode;
                    head.next = node;
                    node.prev = newnode;

                }
                else
                {
                    newnode.next = node;
                    newnode.prev = node.prev;
                    node.prev.next = newnode;
                    node.prev = newnode;
                }
            }
            else
            {
                //случай 1.
                if (head == null)
                {
                    head = newnode;
                    newnode.next = null;
                    newnode.prev = null;
                    tail = newnode;
                }
            }

        }

        public Node<T> Find(T val)
        {
            // здесь будет ваш код

            Node<T> node = head;
            while (node != null)
            {
                if (node.value.Equals(val)) return node;
                node = node.next;
            }
            return null;
        }

        public void Delete(T val)
        {

            Node<T> previous = null;
            Node<T> current = head;
            while (current != null)
            {
                if (current.value.Equals(val))
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
        
    



        public void Clear(bool asc)
        {
            _ascending = asc;
            head = tail = null;
            // здесь будет ваш код
        }

        public int Count()
        {
            // здесь будет ваш код подсчёта количества элементов в списке
            if (head == null) return 0;
            else if (head == tail) return 1;
            else
            {
                Node<T> node = head;
                int count = 0;
                while (node != null)
                {
                    count++;
                    node = node.next;
                }
                return count;
            }
        }

        public List<Node<T>> GetAll() // выдать все элементы упорядоченного 
                               // списка в виде стандартного списка
        {
            List<Node<T>> r = new List<Node<T>>();
            Node<T> node = head;
            while (node != null)
            {
                r.Add(node);
                node = node.next;
            }
            return r;
        }
    }

}