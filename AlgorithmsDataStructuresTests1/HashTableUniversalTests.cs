using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AlgorithmsDataStructures.Tests
{
    [TestClass()]
    public class HashTableUniversalTests
    {
        [TestMethod()]
        public void HashTableUniversalTest()
        {
            int[] values = new int[100];
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                values[i] = rand.Next(0, 100);
                Thread.Sleep(10);
            }

            HashTableUniversal<int> ttt = new HashTableUniversal<int>(23, 3);
            Thread.Sleep(100);
            HashTableUniversal<string> ttt2 = new HashTableUniversal<string>(23, 3);
            Thread.Sleep(100);
            HashTableUniversal<string> ttt3 = new HashTableUniversal<string>(23, 3);
            int[,] tttres = new int[100,2];
            int[,] tttres2 = new int[100,2];
            int[,] tttres3 = new int[100,2];
            for (int i = 0;i<100; i++)
            {
                tttres[i,0]=ttt.Put(values[i]);
                tttres[i, 1] = values[i];
                tttres2[i,0]=ttt2.Put(values[i].ToString());
                tttres2[i, 1] = values[i];
                tttres3[i,0]=ttt3.Put(values[i].ToString());
                tttres3[i, 1] = values[i];
            }
            
            for (int i = 0; i < 23; i++)
            {   
               Assert.AreEqual(tttres[i,0],ttt.Find(tttres[i,1]));
            }
           
        }

    
    }
}