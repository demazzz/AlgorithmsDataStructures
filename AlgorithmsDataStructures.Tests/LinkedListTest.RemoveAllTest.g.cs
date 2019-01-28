using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures;
// <copyright file="LinkedListTest.RemoveAllTest.g.cs">Copyright ©  2019</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace AlgorithmsDataStructures.Tests
{
    public partial class LinkedListTest
    {

[TestMethod]
[PexGeneratedBy(typeof(LinkedListTest))]
public void RemoveAllTest507()
{
    LinkedList linkedList;
    linkedList = new LinkedList();
    linkedList.head = (Node)null;
    linkedList.tail = (Node)null;
    this.RemoveAllTest(linkedList, 0);
    Assert.IsNotNull((object)linkedList);
    Assert.IsNull((object)(linkedList.head));
    Assert.IsNull((object)(linkedList.tail));
}

[TestMethod]
[PexGeneratedBy(typeof(LinkedListTest))]
public void RemoveAllTest997()
{
    LinkedList linkedList;
    Node s0 = new Node(0);
    s0.next = (Node)null;
    linkedList = new LinkedList();
    linkedList.head = s0;
    linkedList.tail = (Node)null;
    this.RemoveAllTest(linkedList, 0);
    Assert.IsNotNull((object)linkedList);
    Assert.IsNull((object)(linkedList.head));
    Assert.IsNull((object)(linkedList.tail));
}

[TestMethod]
[PexGeneratedBy(typeof(LinkedListTest))]
public void RemoveAllTest600()
{
    LinkedList linkedList;
    Node s0 = new Node(0);
    Node s1 = new Node(0);
    s1.next = (Node)null;
    s0.next = s1;
    linkedList = new LinkedList();
    linkedList.head = s0;
    linkedList.tail = (Node)null;
    this.RemoveAllTest(linkedList, 0);
    Assert.IsNotNull((object)linkedList);
    Assert.IsNull((object)(linkedList.head));
    Assert.IsNull((object)(linkedList.tail));
}

[TestMethod]
[PexGeneratedBy(typeof(LinkedListTest))]
public void RemoveAllTest719()
{
    LinkedList linkedList;
    Node s0 = new Node(0);
    s0.next = (Node)null;
    linkedList = new LinkedList();
    linkedList.head = s0;
    linkedList.tail = (Node)null;
    this.RemoveAllTest(linkedList, 1);
    Assert.IsNotNull((object)linkedList);
    Assert.IsNotNull((object)(linkedList.head));
    Assert.IsNull((object)(linkedList.head.next));
    Assert.AreEqual<int>(0, linkedList.head.value);
    Assert.IsNull((object)(linkedList.tail));
}

[TestMethod]
[PexGeneratedBy(typeof(LinkedListTest))]
public void RemoveAllTest773()
{
    LinkedList linkedList;
    Node s0 = new Node(0);
    s0.next = (Node)null;
    linkedList = new LinkedList();
    linkedList.head = s0;
    linkedList.tail = s0;
    this.RemoveAllTest(linkedList, 0);
    Assert.IsNotNull((object)linkedList);
    Assert.IsNull((object)(linkedList.head));
    Assert.IsNull((object)(linkedList.tail));
}

[TestMethod]
[PexGeneratedBy(typeof(LinkedListTest))]
public void RemoveAllTest213()
{
    LinkedList linkedList;
    Node s0 = new Node(0);
    Node s1 = new Node(0);
    s1.next = (Node)null;
    s0.next = s1;
    linkedList = new LinkedList();
    linkedList.head = s0;
    linkedList.tail = s0;
    this.RemoveAllTest(linkedList, 1);
    Assert.IsNotNull((object)linkedList);
    Assert.IsNotNull((object)(linkedList.head));
    Assert.IsNotNull((object)(linkedList.head.next));
    Assert.IsNull((object)(linkedList.head.next.next));
    Assert.AreEqual<int>(0, linkedList.head.next.value);
    Assert.AreEqual<int>(0, linkedList.head.value);
    Assert.IsNotNull((object)(linkedList.tail));
    Assert.IsTrue(object.ReferenceEquals
                      ((object)(linkedList.tail), (object)(linkedList.head.next)));
}

[TestMethod]
[PexGeneratedBy(typeof(LinkedListTest))]
public void RemoveAllTest165()
{
    LinkedList linkedList;
    Node s0 = new Node(0);
    Node s1 = new Node(1);
    s1.next = (Node)null;
    s0.next = s1;
    linkedList = new LinkedList();
    linkedList.head = s0;
    linkedList.tail = s0;
    this.RemoveAllTest(linkedList, 1);
    Assert.IsNotNull((object)linkedList);
    Assert.IsNotNull((object)(linkedList.head));
    Assert.IsNull((object)(linkedList.head.next));
    Assert.AreEqual<int>(0, linkedList.head.value);
    Assert.IsNotNull((object)(linkedList.tail));
    Assert.IsNull((object)(linkedList.tail.next));
    Assert.AreEqual<int>(1, linkedList.tail.value);
}

[TestMethod]
[PexGeneratedBy(typeof(LinkedListTest))]
public void RemoveAllTest393()
{
    LinkedList linkedList;
    Node s0 = new Node(0);
    Node s1 = new Node(0);
    Node s2 = new Node(0);
    s2.next = (Node)null;
    s1.next = s2;
    s0.next = s1;
    linkedList = new LinkedList();
    linkedList.head = s0;
    linkedList.tail = s0;
    this.RemoveAllTest(linkedList, 1);
    Assert.IsNotNull((object)linkedList);
    Assert.IsNotNull((object)(linkedList.head));
    Assert.IsNotNull((object)(linkedList.head.next));
    Assert.IsNotNull((object)(linkedList.head.next.next));
    Assert.IsNull((object)(linkedList.head.next.next.next));
    Assert.AreEqual<int>(0, linkedList.head.next.next.value);
    Assert.AreEqual<int>(0, linkedList.head.next.value);
    Assert.AreEqual<int>(0, linkedList.head.value);
    Assert.IsNotNull((object)(linkedList.tail));
    Assert.IsTrue(object.ReferenceEquals
                      ((object)(linkedList.tail), (object)(linkedList.head.next.next)));
}

[TestMethod]
[PexGeneratedBy(typeof(LinkedListTest))]
public void RemoveAllTest174()
{
    LinkedList linkedList;
    Node s0 = new Node(0);
    Node s1 = new Node(0);
    Node s2 = new Node(0);
    Node s3 = new Node(0);
    s3.next = (Node)null;
    s2.next = s3;
    s1.next = s2;
    s0.next = s1;
    linkedList = new LinkedList();
    linkedList.head = s0;
    linkedList.tail = s0;
    this.RemoveAllTest(linkedList, 1);
    Assert.IsNotNull((object)linkedList);
    Assert.IsNotNull((object)(linkedList.head));
    Assert.IsNotNull((object)(linkedList.head.next));
    Assert.IsNotNull((object)(linkedList.head.next.next));
    Assert.IsNotNull((object)(linkedList.head.next.next.next));
    Assert.IsNull((object)(linkedList.head.next.next.next.next));
    Assert.AreEqual<int>(0, linkedList.head.next.next.next.value);
    Assert.AreEqual<int>(0, linkedList.head.next.next.value);
    Assert.AreEqual<int>(0, linkedList.head.next.value);
    Assert.AreEqual<int>(0, linkedList.head.value);
    Assert.IsNotNull((object)(linkedList.tail));
    Assert.IsTrue(object.ReferenceEquals
                      ((object)(linkedList.tail), (object)(linkedList.head.next.next.next)));
}

[TestMethod]
[PexGeneratedBy(typeof(LinkedListTest))]
public void RemoveAllTest31()
{
    LinkedList linkedList;
    Node s0 = new Node(0);
    Node s1 = new Node(1);
    Node s2 = new Node(1);
    s2.next = (Node)null;
    s1.next = s2;
    s0.next = s1;
    linkedList = new LinkedList();
    linkedList.head = s0;
    linkedList.tail = s0;
    this.RemoveAllTest(linkedList, 1);
    Assert.IsNotNull((object)linkedList);
    Assert.IsNotNull((object)(linkedList.head));
    Assert.IsNull((object)(linkedList.head.next));
    Assert.AreEqual<int>(0, linkedList.head.value);
    Assert.IsNotNull((object)(linkedList.tail));
    Assert.IsNull((object)(linkedList.tail.next));
    Assert.AreEqual<int>(1, linkedList.tail.value);
}

[TestMethod]
[PexGeneratedBy(typeof(LinkedListTest))]
public void RemoveAllTest848()
{
    Node node;
    LinkedList linkedList;
    node = new Node(0);
    node.next = (Node)null;
    node.value = 0;
    node.prev = (Node)null;
    linkedList = new LinkedList();
    linkedList.head = node;
    linkedList.tail = (Node)null;
    this.RemoveAllTest(linkedList, 0);
    Assert.IsNotNull((object)linkedList);
    Assert.IsNull((object)(linkedList.head));
    Assert.IsNull((object)(linkedList.tail));
}

[TestMethod]
[PexGeneratedBy(typeof(LinkedListTest))]
public void RemoveAllTest394()
{
    Node node;
    LinkedList linkedList;
    node = new Node(0);
    node.next = (Node)null;
    node.value = 0;
    node.prev = (Node)null;
    linkedList = new LinkedList();
    linkedList.head = node;
    linkedList.tail = (Node)null;
    this.RemoveAllTest(linkedList, 1);
    Assert.IsNotNull((object)linkedList);
    Assert.IsNotNull((object)(linkedList.head));
    Assert.IsNull((object)(linkedList.head.next));
    Assert.AreEqual<int>(0, linkedList.head.value);
    Assert.IsNull((object)(linkedList.head.prev));
    Assert.IsNull((object)(linkedList.tail));
}

[TestMethod]
[PexGeneratedBy(typeof(LinkedListTest))]
public void RemoveAllTest572()
{
    Node node;
    Node node1;
    LinkedList linkedList;
    node = new Node(0);
    node.next = (Node)null;
    node.value = 0;
    node.prev = (Node)null;
    node1 = new Node(0);
    node1.next = node;
    node1.value = 0;
    node1.prev = (Node)null;
    linkedList = new LinkedList();
    linkedList.head = node1;
    linkedList.tail = (Node)null;
    this.RemoveAllTest(linkedList, 0);
    Assert.IsNotNull((object)linkedList);
    Assert.IsNull((object)(linkedList.head));
    Assert.IsNull((object)(linkedList.tail));
}

[TestMethod]
[PexGeneratedBy(typeof(LinkedListTest))]
public void RemoveAllTest872()
{
    Node node;
    Node node1;
    Node node2;
    LinkedList linkedList;
    node = new Node(0);
    node.next = (Node)null;
    node.value = 0;
    node.prev = (Node)null;
    node1 = new Node(0);
    node1.next = node;
    node1.value = 1048576;
    node1.prev = (Node)null;
    node2 = new Node(0);
    node2.next = node1;
    node2.value = 1048576;
    node2.prev = (Node)null;
    linkedList = new LinkedList();
    linkedList.head = node2;
    linkedList.tail = (Node)null;
    this.RemoveAllTest(linkedList, 1048576);
    Assert.IsNotNull((object)linkedList);
    Assert.IsNotNull((object)(linkedList.head));
    Assert.IsNull((object)(linkedList.head.next));
    Assert.AreEqual<int>(0, linkedList.head.value);
    Assert.IsNull((object)(linkedList.head.prev));
    Assert.IsNull((object)(linkedList.tail));
}

[TestMethod]
[PexGeneratedBy(typeof(LinkedListTest))]
public void RemoveAllTest84()
{
    Node node;
    Node node1;
    Node node2;
    Node node3;
    LinkedList linkedList;
    node = new Node(0);
    node.next = (Node)null;
    node.value = 0;
    node.prev = (Node)null;
    node1 = new Node(0);
    node1.next = node;
    node1.value = 8192;
    node1.prev = (Node)null;
    node2 = new Node(0);
    node2.next = node1;
    node2.value = 0;
    node2.prev = (Node)null;
    node3 = new Node(0);
    node3.next = node2;
    node3.value = 0;
    node3.prev = (Node)null;
    linkedList = new LinkedList();
    linkedList.head = node3;
    linkedList.tail = (Node)null;
    this.RemoveAllTest(linkedList, 0);
    Assert.IsNotNull((object)linkedList);
    Assert.IsNotNull((object)(linkedList.head));
    Assert.IsNull((object)(linkedList.head.next));
    Assert.AreEqual<int>(8192, linkedList.head.value);
    Assert.IsNull((object)(linkedList.head.prev));
    Assert.IsNotNull((object)(linkedList.tail));
    Assert.IsTrue(
                 object.ReferenceEquals((object)(linkedList.tail), (object)(linkedList.head))
                 );
}

[TestMethod]
[PexGeneratedBy(typeof(LinkedListTest))]
public void RemoveAllTest52()
{
    Node node;
    Node node1;
    Node node2;
    Node node3;
    Node node4;
    LinkedList linkedList;
    node = new Node(0);
    node.next = (Node)null;
    node.value = 0;
    node.prev = (Node)null;
    node1 = new Node(0);
    node1.next = node;
    node1.value = 8;
    node1.prev = (Node)null;
    node2 = new Node(0);
    node2.next = node1;
    node2.value = 0;
    node2.prev = (Node)null;
    node3 = new Node(0);
    node3.next = node2;
    node3.value = 8;
    node3.prev = (Node)null;
    node4 = new Node(0);
    node4.next = node3;
    node4.value = 8;
    node4.prev = (Node)null;
    linkedList = new LinkedList();
    linkedList.head = node4;
    linkedList.tail = (Node)null;
    this.RemoveAllTest(linkedList, 8);
    Assert.IsNotNull((object)linkedList);
    Assert.IsNotNull((object)(linkedList.head));
    Assert.IsNotNull((object)(linkedList.head.next));
    Assert.IsNull((object)(linkedList.head.next.next));
    Assert.AreEqual<int>(0, linkedList.head.next.value);
    Assert.IsNotNull((object)(linkedList.head.next.prev));
    Assert.IsTrue(object.ReferenceEquals
                      ((object)(linkedList.head.next.prev), (object)(linkedList.head)));
    Assert.AreEqual<int>(0, linkedList.head.value);
    Assert.IsNull((object)(linkedList.head.prev));
    Assert.IsNull((object)(linkedList.tail));
}

[TestMethod]
[PexGeneratedBy(typeof(LinkedListTest))]
public void RemoveAllTest614()
{
    Node node;
    Node node1;
    Node node2;
    Node node3;
    Node node4;
    LinkedList linkedList;
    node = new Node(0);
    node.next = (Node)null;
    node.value = 0;
    node.prev = (Node)null;
    node1 = new Node(0);
    node1.next = node;
    node1.value = 0;
    node1.prev = (Node)null;
    node2 = new Node(0);
    node2.next = node1;
    node2.value = 4;
    node2.prev = (Node)null;
    node3 = new Node(0);
    node3.next = node2;
    node3.value = 0;
    node3.prev = (Node)null;
    node4 = new Node(0);
    node4.next = node3;
    node4.value = 0;
    node4.prev = (Node)null;
    linkedList = new LinkedList();
    linkedList.head = node4;
    linkedList.tail = (Node)null;
    this.RemoveAllTest(linkedList, 0);
    Assert.IsNotNull((object)linkedList);
    Assert.IsNotNull((object)(linkedList.head));
    Assert.IsNotNull((object)(linkedList.head.next));
    Assert.IsNull((object)(linkedList.head.next.next));
    Assert.AreEqual<int>(0, linkedList.head.next.value);
    Assert.IsNotNull((object)(linkedList.head.next.prev));
    Assert.IsTrue(object.ReferenceEquals
                      ((object)(linkedList.head.next.prev), (object)(linkedList.head)));
    Assert.AreEqual<int>(4, linkedList.head.value);
    Assert.IsNull((object)(linkedList.head.prev));
    Assert.IsNotNull((object)(linkedList.tail));
    Assert.IsNull((object)(linkedList.tail.next));
    Assert.AreEqual<int>(0, linkedList.tail.value);
    Assert.IsNull((object)(linkedList.tail.prev));
}

[TestMethod]
[PexGeneratedBy(typeof(LinkedListTest))]
public void RemoveAllTest159()
{
    Node node;
    Node node1;
    Node node2;
    Node node3;
    Node node4;
    LinkedList linkedList;
    node = new Node(0);
    node.next = (Node)null;
    node.value = 0;
    node.prev = (Node)null;
    node1 = new Node(0);
    node1.next = node;
    node1.value = 8;
    node1.prev = (Node)null;
    node2 = new Node(0);
    node2.next = node1;
    node2.value = 8;
    node2.prev = (Node)null;
    node3 = new Node(0);
    node3.next = node2;
    node3.value = 262145;
    node3.prev = (Node)null;
    node4 = new Node(0);
    node4.next = node3;
    node4.value = 8;
    node4.prev = (Node)null;
    linkedList = new LinkedList();
    linkedList.head = node4;
    linkedList.tail = (Node)null;
    this.RemoveAllTest(linkedList, 8);
    Assert.IsNotNull((object)linkedList);
    Assert.IsNotNull((object)(linkedList.head));
    Assert.IsNotNull((object)(linkedList.head.next));
    Assert.IsNotNull((object)(linkedList.head.next.next));
    Assert.IsNull((object)(linkedList.head.next.next.next));
    Assert.AreEqual<int>(0, linkedList.head.next.next.value);
    Assert.IsNotNull((object)(linkedList.head.next.next.prev));
    Assert.IsNotNull((object)(linkedList.head.next.next.prev.next));
    Assert.IsTrue
        (object.ReferenceEquals((object)(linkedList.head.next.next.prev.next), 
                                (object)(linkedList.head.next.next)));
    Assert.AreEqual<int>(8, linkedList.head.next.next.prev.value);
    Assert.IsNull((object)(linkedList.head.next.next.prev.prev));
    Assert.AreEqual<int>(8, linkedList.head.next.value);
    Assert.IsNotNull((object)(linkedList.head.next.prev));
    Assert.IsTrue(object.ReferenceEquals
                      ((object)(linkedList.head.next.prev), (object)(linkedList.head)));
    Assert.AreEqual<int>(262145, linkedList.head.value);
    Assert.IsNull((object)(linkedList.head.prev));
    Assert.IsNull((object)(linkedList.tail));
}
    }
}
