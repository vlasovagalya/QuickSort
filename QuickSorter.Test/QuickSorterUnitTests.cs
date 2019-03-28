using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSorter;

namespace QuickSorter.Test
{
    [TestClass]
    public class QuickSorterUnitTests
    {
        [TestMethod]
        public void Test3Elements()
        {
            var a = 1;
            var b = 3;
            var c = 2;

            QuickSortClass.QuickSort(a, b, c);
            Assert.IsTrue(a< c && c < b);
        }

        [TestMethod]
        public void Test100IdenticalElements()
        {
            var array = new int[100];

            QuickSortClass.QuickSort(array);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 0;
                Assert.AreEqual(array[i], 0);
            }
        }

        [TestMethod]
        public void Test1000Elements()
        {
            var random = new Random();
            var array = new int[1000];
            
            QuickSortClass.QuickSort(array);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
                var x = random.Next(100);
                var y = random.Next(100);
                while (x < y)
                {
                    x = random.Next(100);
                    y = random.Next(100);
                }
                Assert.IsTrue(array[x] > array[y]);
            }
        }

        [TestMethod]
        public void TestEmptyArray()
        {
            var array = new int[] { };

            QuickSortClass.QuickSort(array);
        }
    }
}
