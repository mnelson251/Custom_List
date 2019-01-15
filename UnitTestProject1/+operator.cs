using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class PlusOperator
    {
        [TestMethod]
        public void plusOp_ConcatTwoLists_ValueAtIndex4()
        {
            //Arrange
            List_Custom<int> list1 = new List_Custom<int>();
            List_Custom<int> list2 = new List_Custom<int>();
            List_Custom<int> list3 = new List_Custom<int>();
            int list1index0 = 10;
            int list1index1 = 20;
            int list1index2 = 40;
            int list1index3 = 60;
            int list2index0 = 15;
            int list2index1 = 25;
            int list2index2 = 35;
            int list2index3 = 45;
            
            list1.Add(list1index0);
            list1.Add(list1index1);
            list1.Add(list1index2);
            list1.Add(list1index3);
            list1.Add(list2index0);
            list1.Add(list2index1);
            list1.Add(list2index2);
            list1.Add(list2index3);
            //Act
            list3 = list1 + list2;
            //Assert
            Assert.AreEqual(list2index0, list3[4]);
        }

        [TestMethod]
        public void PlusOp_ConcatTwoLists_ValueAtIndex3()
        {
            //Arrange
            List_Custom<int> list1 = new List_Custom<int>();
            List_Custom<int> list2 = new List_Custom<int>();
            List_Custom<int> list3 = new List_Custom<int>();
            int list1index0 = 10;
            int list1index1 = 20;
            int list1index2 = 40;
            int list1index3 = 60;
            int list2index0 = 15;
            int list2index1 = 25;
            int list2index2 = 35;
            int list2index3 = 45;

            list1.Add(list1index0);
            list1.Add(list1index1);
            list1.Add(list1index2);
            list1.Add(list1index3);
            list1.Add(list2index0);
            list1.Add(list2index1);
            list1.Add(list2index2);
            list1.Add(list2index3);
            //Act
            list3 = list1 + list2;
            //Assert
            Assert.AreEqual(list1index3, list3[3]);
        }

        [TestMethod]
        public void PlusOp_ConcatTwoLists_()
        {
            //Arrange
            List_Custom<int> list1 = new List_Custom<int>();
            List_Custom<int> list2 = new List_Custom<int>();
            List_Custom<int> list3 = new List_Custom<int>();
            int list1index0 = 10;
            int list1index1 = 20;
            int list2index0 = 15;
            int list2index1 = 25;
            list1.Add(list1index0);
            list1.Add(list1index1);
            list2.Add(list2index0);
            list2.Add(list2index1);
            //Act
            list3 = list1 + list2;
            //Assert
            Assert.AreEqual(list1index1, list3[1]);
        }

        [TestMethod]
        public void PlusOp_CountOfNewList_CountReflectsAddedValues()
        {
            //Arrange
            List_Custom<int> list1 = new List_Custom<int>();
            List_Custom<int> list2 = new List_Custom<int>();
            List_Custom<int> list3 = new List_Custom<int>();
            int list1index0 = 10;
            int list1index1 = 20;
            int list2index0 = 15;
            int list2index1 = 25;
            list1.Add(list1index0);
            list1.Add(list1index1);
            list1.Add(list2index0);
            list1.Add(list2index1);
            //Act
            list3 = list1 + list2;
            //Assert
            Assert.AreEqual(4, list3.count);
        }

        [TestMethod]
        public void PlusOp_NewListBehavior_IndexInCorrectPostion()
        {
            //Arrange
            List_Custom<int> list1 = new List_Custom<int>();
            List_Custom<int> list2 = new List_Custom<int>();
            List_Custom<int> list3 = new List_Custom<int>();
            int list1index0 = 10;
            int list1index1 = 20;
            int list2index0 = 15;
            int list2index1 = 25;
            list1.Add(list1index0);
            list1.Add(list1index1);
            list1.Add(list2index0);
            list1.Add(list2index1);
            //Act
            list3 = list1 + list2;
            list3.Remove(list3[1]);
            //Assert
            Assert.AreEqual(3, list3.count);
        }

        [TestMethod]
        public void PlusOp_NewListBehaveCount_CountRelfectsCorrectly()
        {
            //Arrange
            List_Custom<int> list1 = new List_Custom<int>();
            List_Custom<int> list2 = new List_Custom<int>();
            List_Custom<int> list3 = new List_Custom<int>();
            int list1index0 = 10;
            int list1index1 = 20;
            int list2index0 = 15;
            int list2index1 = 25;
            list1.Add(list1index0);
            list1.Add(list1index1);
            list1.Add(list2index0);
            list1.Add(list2index1);
            //Act
            list3 = list1 + list2;
            list3.Remove(list3[1]);
            list3.Add(list1index1);
            //Assert
            Assert.AreEqual(4, list3.count);
        }

        [TestMethod]
        public void PlusOp_ListBehaveAdd_ReorderOfIndexs()
        {
            //Arrange
            List_Custom<int> list1 = new List_Custom<int>();
            List_Custom<int> list2 = new List_Custom<int>();
            List_Custom<int> list3 = new List_Custom<int>();
            int list1index0 = 10;
            int list1index1 = 20;
            int list2index0 = 15;
            int list2index1 = 25;
            list1.Add(list1index0);
            list1.Add(list1index1);
            list1.Add(list2index0);
            list1.Add(list2index1);
            //Act
            list3 = list1 + list2;
            list3.Remove(list3[1]);
            list3.Add(list1index1);
            //Assert
            Assert.AreEqual(list1index1, list3[3]);
        }
    }
}
