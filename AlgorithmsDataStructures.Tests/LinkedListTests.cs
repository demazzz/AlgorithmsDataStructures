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
    public class LinkedListTests
    {
        [TestMethod()]
        public void RemoveAllTest()
        {
            Node node1 = new Node(1);
            LinkedList aaa = new LinkedList();
            aaa.AddInTail(new Node(1));
            aaa.AddInTail(new Node(3));
            aaa.AddInTail(new Node(3));
            //act
            aaa.RemoveAll(1);

            //Assert
            LinkedList bbb = new LinkedList();
            bbb.AddInTail(new Node(3));
            Assert.AreEqual(bbb.head.value, aaa.head.value);
            
        }
    }
}