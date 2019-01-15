using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class Iterator
    {
        [TestMethod]
        public void Iteration_AddingByForeach_IndexMatch()
        {
            List_Custom<int> list1 = new List_Custom<int>() { 2, 4, 6, 8, 10 };
            List_Custom<int> list2 = new List_Custom<int>();
            foreach(int p in list1)
            {
             list2.Add(p);
            }
            Assert.AreEqual(list2[3], list1[3]);
        }

        [TestMethod]
        public void Iteration_CloneContent_UnevenListValues ()
        {
            List_Custom<int> list1 = new List_Custom<int>() { 2, 4, 6, 8, 10 };
            List_Custom<int> list2 = new List_Custom<int>() { 1, 1 };
            foreach (int p in list1)
            {
                list2.Add(p);
            }
            Assert.AreEqual(list2[3], list1[1]);
        }



    }
}
