using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArrayManipulationsTests
{
    [TestClass]
    public class ArraySortTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange
            int[] a = { 20, 1, 3, -1, 0, 33, -1444 };
            MyBubbleSort.ArraySort c = new MyBubbleSort.ArraySort();
            int[] actual = { -1444, -1, 0, 1, 3, 20 , 33 };
            // act
            int[] result = c.BubbleSort(true, a);
            // assert
            CollectionAssert.AreEqual(actual, result);
            
        }

        [TestMethod]
        public void TestMethod2()
        {
            // arrange
            int[][] a = new int[6][];
            a[0] = new int[] { 1, 2, 3, 5 };
            a[1] = new int[] { 0 };
            a[2] = new int[] { 101, -1, 0, 53, 3, -23, 111, 5934, 33 };
            a[3] = new int[] { -1 };
            a[4] = new int[] { -1, -1, -1};
            a[5] = new int[] { 0, 0, 334};
            MyBubbleSort.ArrayManipulations c = new MyBubbleSort.ArrayManipulations();
            int[] actual = { 5, 0, 5934, -1, -1, 334 };


            // act
            int[] result = c.FindMaxmInArray(a);
            // assert
            CollectionAssert.AreEqual(actual, result);
        }
    }
}
