using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class MinusOperator
    {
        [TestMethod]
        public void MinuOp_RemovingValuesFromList_NewListIndexMatch ()
        {
            //Arrange
            List_Custom<int> list1 = new List_Custom<int>();
            List_Custom<int> list2 = new List_Custom<int>();
            List_Custom<int> list3 = new List_Custom<int>();
            int list1index0 = 10;
            int list1index1 = 20;
            int list1index2 = 25;
            int list2index0 = 15;
            int list2index1 = 25;
            int list2index2 = 10;
            list1.Add(list1index0);
            list1.Add(list1index1);
            list1.Add(list1index2);
            list2.Add(list2index0);
            list2.Add(list2index1);
            list2.Add(list2index2);
            //Act
            list3 = list1 - list2;
            //Assert
            Assert.AreEqual(list1index1, list3[0]);
        }

        [TestMethod]
        public void MinuOp_RemovingEntireListContents_RemnantsHaveIndex()
        {
            //Arrange
            List_Custom<int> list1 = new List_Custom<int>();
            List_Custom<int> list2 = new List_Custom<int>();
            List_Custom<int> list3 = new List_Custom<int>();
            int list1index0 = 10;
            int list1index1 = 20;
            int list1index2 = 25;
            int list1index3 = 30;
            int list1index4 = 35;
            int list1index5 = 35;
            int list2index0 = 15;
            int list2index1 = 25;
            int list2index2 = 10;
            int list2index3 = 30;
            int list2index4 = 35;
            list1.Add(list1index0);
            list1.Add(list1index1);
            list1.Add(list1index2);
            list2.Add(list2index0);
            list2.Add(list2index1);
            list2.Add(list2index2);
            list1.Add(list1index3);
            list1.Add(list1index4);
            list2.Add(list2index3);
            list2.Add(list2index4);
            list2.Add(list1index5);
            //Act
            list3 = list1 - list2;
            //Assert
            Assert.AreEqual(list1index1, list3[0]);
        }


    }
}
