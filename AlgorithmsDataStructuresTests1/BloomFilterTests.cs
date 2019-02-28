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
    public class BloomFilterTests
    {
        [TestMethod()]
        public void BloomFilterTest()
        {
            List<string> list = new List<string>();
            string str = "0123456789";
            list.Add(str);
            for (int i = 0; i < 9; i++)
            {
                str = str.Substring(1, str.Length - 1) + str.Substring(0, 1);
                list.Add(str);
            }
            BloomFilter filer = new BloomFilter(32);
            filer.Add("0123456789");
            for (int i = 0; i < 10; i++)
            {
               
                if (filer.IsValue(list[i]))
                {
                    Assert.Fail();
                }
            }
        }
    }
}
