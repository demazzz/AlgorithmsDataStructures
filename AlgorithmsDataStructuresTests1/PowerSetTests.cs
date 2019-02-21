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
    public class PowerSetTests
    {
        [TestMethod()]
        public void GeneralTestusingCount()
        {
            PowerSet<int> iii = new PowerSet<int>();
            iii.Put(10);
            if (iii.Size()!= 1) Assert.Fail();
            iii.Put(10);
            if (iii.Size() != 1) Assert.Fail();
            iii.Put(20);
            if (iii.Size() != 2) Assert.Fail();
            iii.Remove(10);
            if (iii.Size() != 1) Assert.Fail();
            if (!iii.Get(20)) Assert.Fail();
        }
        [TestMethod()]
        public void intersectionTest()
        {
            PowerSet<int> s1 = new PowerSet<int>();
            PowerSet<int> s2 = new PowerSet<int>();
            s1.Put(1);
            s1.Put(2);
            s1.Put(3);
            s1.Put(4);
            s2.Put(1);
            s2.Put(2);
            //s2.Put(4);
            s2.Put(6);
            PowerSet<int> s3 = s1.Intersection(s2);
            if (s3.Size()!=2) Assert.Fail();

        }
        [TestMethod()]
        public void intersectionTestempty()
        {
            PowerSet<int> s1 = new PowerSet<int>();
            PowerSet<int> s2 = new PowerSet<int>();
            s1.Put(1);
            //s1.Put(2);
            s1.Put(3);
            //s1.Put(4);
            //s2.Put(1);
            s2.Put(2);
            s2.Put(4);
            s2.Put(6);
            PowerSet<int> s3 = s1.Intersection(s2);
            if (s3.Size()!=0) Assert.Fail();
        }
        [TestMethod()]
        public void intersectionTestEmptyOne()
        {
            PowerSet<int> s1 = new PowerSet<int>();
            PowerSet<int> s2 = new PowerSet<int>();
            s2.Put(1);
            s2.Put(2);
            s2.Put(4);
            s2.Put(6);
            PowerSet<int> s3 = s1.Intersection(s2);
            if ((s3.Size() != 0)) Assert.Fail();
        }
        [TestMethod()]
        public void intersectionTestEmptyTwo()
        {
            PowerSet<int> s1 = new PowerSet<int>();
            PowerSet<int> s2 = new PowerSet<int>();
            s1.Put(1);
            s1.Put(2);
            s1.Put(3);
            s1.Put(4);
            PowerSet<int> s3 = s1.Intersection(s2);
            if ((s3.Size() != 0)) Assert.Fail();
        }
        
        

        [TestMethod()]
        public void DifferenceTest()
        {
            PowerSet<int> s1 = new PowerSet<int>();
            PowerSet<int> s2 = new PowerSet<int>();
            s1.Put(1);
            s1.Put(2);
            s1.Put(3);
            s1.Put(4);
            //s2.Put(1);
            s2.Put(2);
            s2.Put(4);
            s2.Put(6);
            PowerSet<int> s3 = s1.Difference(s2);
            if (s3.Size() != 2) Assert.Fail();
        }
        [TestMethod()]
        public void DifferenceEmptryOne()
        {
            PowerSet<int> s1 = new PowerSet<int>();
            PowerSet<int> s2 = new PowerSet<int>();
            s2.Put(1);
            s2.Put(2);
            s2.Put(4);
            s2.Put(6);
            PowerSet<int> s3 = s1.Difference(s2);
            if (s3.Size() != 0) Assert.Fail();
        }
        [TestMethod()]
        public void DifferenceEmptryTwo()
        {
            PowerSet<int> s1 = new PowerSet<int>();
            PowerSet<int> s2 = new PowerSet<int>();
            s1.Put(1);
            s1.Put(2);
            s1.Put(3);
            s1.Put(4);
            PowerSet<int> s3 = s1.Difference(s2);
            if (s3.Size() != 4) Assert.Fail();

        }
        [TestMethod()]
        public void SizeTest()
        {
            PowerSet<string> s1 = new PowerSet<string>();
            if (s1.Size() != 0) Assert.Fail();
            s1.Put("erer");
            if (s1.Size() != 1) Assert.Fail();
            s1.Put("erer");
            if (s1.Size() != 1) Assert.Fail();
            s1.Put("erere");
            if (s1.Size() != 2) Assert.Fail();
            s1.Put("serer");
            s1.Put("erer");
            if (s1.Size() != 3) Assert.Fail();
            s1.Remove("erer");
            if (s1.Size() != 2) Assert.Fail();
        }

        [TestMethod()]
        public void unionTestEmptyOne()
        {
            PowerSet<int> s1 = new PowerSet<int>();
            PowerSet<int> s2 = new PowerSet<int>();
            s1.Put(1);
            s1.Put(2);
            s1.Put(3);
            s1.Put(4);
            PowerSet<int> s3 = s1.Union(s2);
            if (s3.Size() != 4) Assert.Fail();
        }
        [TestMethod()]
        public void unionTestEmptyTwo()
        {
            PowerSet<int> s1 = new PowerSet<int>();
            PowerSet<int> s2 = new PowerSet<int>();
            s2.Put(1);
            s2.Put(2);
            s2.Put(4);
            s2.Put(6);
            PowerSet<int> s3 = s1.Union(s2);
            if (s3.Size() != 4) Assert.Fail();
        }
        [TestMethod()]
        public void unionBothEmpty()
        {
            PowerSet<int> s1 = new PowerSet<int>();
            PowerSet<int> s2 = new PowerSet<int>();
            PowerSet<int> s3 = s1.Union(s2);
            if (s3.Size() != 0) Assert.Fail();
        }
        [TestMethod()]
        public void unionTest()
        {
            PowerSet<int> s1 = new PowerSet<int>();
            PowerSet<int> s2 = new PowerSet<int>();
            s1.Put(1);
            s1.Put(2);
            s1.Put(3);
            s1.Put(4);
            s2.Put(1);
            s2.Put(2);
            s2.Put(4);
            s2.Put(6);
            PowerSet<int> s3 = s1.Union(s2);
            if (s3.Size() != 5) Assert.Fail();
        }
        [TestMethod()]
        public void IsSubsetOneEmpty()
        {
            PowerSet<int> s1 = new PowerSet<int>();
            PowerSet<int> s2 = new PowerSet<int>();
            s2.Put(1);
            s2.Put(2);
            s2.Put(4);
            s2.Put(6);
            bool res = s1.IsSubset(s2);
            if (res) Assert.Fail();
        }
        [TestMethod()]
        public void IsSubsetTwoEmpty()
        {
            PowerSet<int> s1 = new PowerSet<int>();
            PowerSet<int> s2 = new PowerSet<int>();
            s1.Put(1);
            s1.Put(2);
            s1.Put(3);
            s1.Put(4);
            bool res = s1.IsSubset(s2);
            if (!res) Assert.Fail();
        }
        [TestMethod()]
        public void IsSubsetBothEmpty()
        {
            PowerSet<int> s1 = new PowerSet<int>();
            PowerSet<int> s2 = new PowerSet<int>();
            bool res = s1.IsSubset(s2);
            if (res) Assert.Fail();
        }
        [TestMethod()]
        public void IsSubsetBothSame()
        {
            PowerSet<int> s1 = new PowerSet<int>();
            PowerSet<int> s2 = new PowerSet<int>();
            s1.Put(1);
            s1.Put(2);
            s1.Put(3);
            s1.Put(4);
            s2.Put(1);
            s2.Put(2);
            s2.Put(3);
            s2.Put(4);
            bool res = s1.IsSubset(s2);
            if (!res) Assert.Fail();
        }
        [TestMethod()]
        public void IsSubsetS1Bigger()
        {
            PowerSet<int> s1 = new PowerSet<int>();
            PowerSet<int> s2 = new PowerSet<int>();
            s1.Put(1);
            s1.Put(2);
            s1.Put(3);
            s1.Put(4);
            s1.Put(5);
            s2.Put(1);
            s2.Put(2);
            s2.Put(3);
            s2.Put(4);
            bool res = s1.IsSubset(s2);
            if (!res) Assert.Fail();
        }
        public void IsSubsetS2Bigger()
        {
            PowerSet<int> s1 = new PowerSet<int>();
            PowerSet<int> s2 = new PowerSet<int>();
            s1.Put(1);
            s1.Put(2);
            s1.Put(3);
            s1.Put(4);
            s2.Put(5);
            s2.Put(1);
            s2.Put(2);
            s2.Put(3);
            s2.Put(4);
            bool res = s1.IsSubset(s2);
            if (res) Assert.Fail();
        }
        public void IsSubsetS2Partial()
        {
            PowerSet<int> s1 = new PowerSet<int>();
            PowerSet<int> s2 = new PowerSet<int>();
            s1.Put(1);
            s1.Put(2);
            s1.Put(3);
            s1.Put(4);
            s1.Put(5);

            s2.Put(1);
            s2.Put(2);

            bool res = s1.IsSubset(s2);
            if (!res) Assert.Fail();
        }
    }
}