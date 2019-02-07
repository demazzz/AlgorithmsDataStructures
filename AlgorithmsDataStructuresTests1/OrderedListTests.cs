using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures.Tests
{
    [TestClass()]
    public class OrderedListTests
    {
        [TestMethod()]
        public void OrderedListTest()
        {
            OrderedList<int> one = new OrderedList<int>(true);
            OrderedList<int> two = new OrderedList<int>(false);
            OrderedList<object> three = new OrderedList<object>(false);
            OrderedList<string> four = new OrderedList<string>(false);
        }
       


        [TestMethod()]
        public void deleteempty()
        {
            OrderedList<int> one = new OrderedList<int>(true);
            one.Delete(1);
            
        }

        [TestMethod()]
        public void deletehead()
        {
            OrderedList<int> one = new OrderedList<int>(true);
            one.Add(1);
            one.Add(0);
            one.Add(2);
            one.Delete(0);
            List<Node<int>> check = new List<Node<int>>();
            check = one.GetAll();
            List<Node<int>> expected = new List<Node<int>>();
            expected.Add(new Node<int>(1)); expected.Add(new Node<int>(2));
            int ans = 0;
            if (expected[0].value == check[0].value && expected[0].value == one.head.value) ans++;
            if (expected[1].value == check[1].value && expected[1].value == one.tail.value) ans++;
            int correct = 2;
            Assert.AreEqual(correct, ans);

        }

        [TestMethod()]
        public void deletetail()
        {
            OrderedList<int> one = new OrderedList<int>(true);
            one.Add(1);
            one.Add(0);
            one.Add(2);
            one.Delete(2);
            List<Node<int>> check = new List<Node<int>>();
            check = one.GetAll();
            List<Node<int>> expected = new List<Node<int>>();
            expected.Add(new Node<int>(0)); expected.Add(new Node<int>(1));
            int ans = 0;
            if (expected[0].value == check[0].value && expected[0].value == one.head.value) ans++;
            if (expected[1].value == check[1].value && expected[1].value == one.tail.value) ans++;
            int correct = 2;
            Assert.AreEqual(correct, ans);

        }

        [TestMethod()]
        public void deleteanotherway()
        {
            OrderedList<object> one = new OrderedList<object>(true);
            one.Add("abc");
            one.Add("bbb");
            one.Add("bca");
            one.Add(3);
            one.Add(2);
            one.Add(1);
            Node<object> foundInt = one.Find(2);
            Node<object> foundStr = one.Find("bbb");
            one.Delete("bbb");
            one.Delete(2);
            if (one.Find("abc") == foundStr.prev)
            {
                if (one.Find("bca") == foundStr.next)
                {
                    if (one.Find(1)==foundInt.prev)
                    {
                        if (one.Find(3) == foundInt.next)
                        {

                        }
                        else Assert.Fail();
                    }
                    else Assert.Fail();
                }
                else Assert.Fail();
            }
            else Assert.Fail();
        }
        [TestMethod()]
        public void GeneralAscTest()
        {
            OrderedList<int> one = new OrderedList<int>(true);
            one.Add(4);
            one.Add(5);
            one.Add(2);
            one.Add(1);
            one.Add(7);
            one.Add(3);
            one.Add(1);
            one.Add(3);
            one.Add(8);
            one.Add(9);
            List<Node<int>> check = new List<Node<int>>();
            check = one.GetAll();
            if (check.Count == one.Count() && check.Count>0)
            {
                int value = check[0].value;
                int actual = 1;
                for (int i = 1; i < check.Count; i++)
                {
                     if (check[i].value>=value)
                    {
                        actual++;
                    }
                     else
                    {
                        Assert.Fail();
                    }
                }
                Assert.AreEqual(check.Count, actual);
            }

        }

        [TestMethod()]
        public void deletemiddleint()
        {
            OrderedList<int> one = new OrderedList<int>(true);
            one.Add(0);
            one.Add(2);
            one.Add(1);
            one.Add(1);
            one.Add(2);
            one.Add(1);
            one.Add(0);
            int count_before = one.Count();
            one.Delete(1);
            int count_after = one.Count();
            int expected = 1;
            int actual = count_before - count_after;
            OrderedList<int> two = new OrderedList<int>(true);
            two.Add(0);
            two.Add(1);
            two.Add(1);
            two.Add(2);
            two.Add(1);
            two.Add(0);
            if (expected==actual && one.Count() == two.Count() && one.Count()==6)
            {
                for (int i =0; i< one.Count(); i++)
                {
                    Node<int> check1 = one.head;
                    Node<int> check2 = two.head;
                    if (check1.value.Equals(check2.value))
                    {
                        check1 = check1.next;
                        check2 = check2.next;
                    }
                    else
                    {
                        Assert.Fail();
                    }
                }
                Assert.ReferenceEquals(one, two);
                
            }
            else
            {
                Assert.Fail();
            }
            
        }
        public void deletemiddleSTR()
        {
            OrderedList<string> one = new OrderedList<string>(true);
            one.Add("A");
            one.Add("C");
            one.Add("B");
            one.Add("B");
            one.Add("C");
            one.Add("B");
            one.Add("A");
            int count_before = one.Count();
            one.Delete("B");
            int count_after = one.Count();
            int expected = 1;
            int actual = count_before - count_after;
            OrderedList<string> two = new OrderedList<string>(true);
            two.Add("A");
            two.Add("C");
            two.Add("B");
            two.Add("C");
            two.Add("B");
            two.Add("A");
            if (expected == actual && one.Count() == two.Count())
            {
                for (int i = 0; i < one.Count(); i++)
                {
                    Node<string> check1 = one.head;
                    Node<string> check2 = two.head;
                    if (check1.value.Equals(check2.value))
                    {
                        check1 = check1.next;
                        check2 = check2.next;
                    }
                    else
                    {
                        Assert.Fail();
                    }
                }
                Assert.ReferenceEquals(one, two);

            }
            else
            {
                Assert.Fail();
            }

        }

        [TestMethod()]
        public void CompareTest()
        {
            OrderedList<object> one = new OrderedList<object>(true);
            
            if (one.Compare("AA", "AB") == 1)
            {
                if (one.Compare(1, 2) == 1)
                {
                    if (one.Compare("AA", "AA") == 0)
                    {
                        if (one.Compare(1, 1) == 0)
                        {
                            if (one.Compare(2, 1) == -1)
                            {
                                if (one.Compare("AB", "AA") == -1)
                                {
                                    
                                }
                                else Assert.Fail();
                            }
                            else Assert.Fail();
                        }
                        else Assert.Fail();
                    }
                    else Assert.Fail();
                }
                else Assert.Fail();
            }
            else Assert.Fail();


        }

        [TestMethod()]
        public void notMyTest()
        {
            
            OrderedList<int> ol = new OrderedList<int>(true);
            ol.Add(0);
            ol.Add(2);
            ol.Add(1);
            ol.Add(1);
            ol.Add(2);
            ol.Add(1);
            ol.Add(0);
            ol.Delete(1);
            if (ol.Count() == 6)
                Assert.AreEqual(6, ol.Count());
            else
                Assert.Fail();


        }

    }
}