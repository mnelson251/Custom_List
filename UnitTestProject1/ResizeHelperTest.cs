using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class ResizeHelperTest
    {
        [TestMethod]
        public void ResizeHelper_doubleSize_intsAdded() // should double the size of the array
        {
            //Arrange
            List_Custom<int> myList = new List_Custom<int>();
            int expectedIndex0 = 10;
            int expectedIndex1 = 5;
            int expectedIndex2 = 3;
            int expectedIndex3 = 2;
            int expectedIndex4 = 7;
            int expectedIndex5 = 8;
            int expectedIndex6 = 9;

            //Act
            myList.cAdd(expectedIndex0);
            myList.cAdd(expectedIndex1);
            myList.cAdd(expectedIndex2);
            myList.cAdd(expectedIndex3);
            myList.cAdd(expectedIndex4);
            myList.cAdd(expectedIndex5);
            myList.cAdd(expectedIndex6);

            //Assert
            Assert.AreEqual(expectedIndex5, myList[5]);
        }

        [TestMethod]
        public void ResizeHelper_QuadSizeofOrignial_intsAdded() // array of size 8 should double to 16
        {
            //Arrange
            List_Custom<int> myList = new List_Custom<int>();
            int expectedIndex0 = 10;
            int expectedIndex1 = 5;
            int expectedIndex2 = 3;
            int expectedIndex3 = 2;
            int expectedIndex4 = 7;
            int expectedIndex5 = 8;
            int expectedIndex6 = 9;
            int expectedIndex7 = 10;
            int expectedIndex8 = 11;

            //Act
            myList.cAdd(expectedIndex0);
            myList.cAdd(expectedIndex1);
            myList.cAdd(expectedIndex2);
            myList.cAdd(expectedIndex3);
            myList.cAdd(expectedIndex4);
            myList.cAdd(expectedIndex5);
            myList.cAdd(expectedIndex6);
            myList.cAdd(expectedIndex7);
            myList.cAdd(expectedIndex8);

            //Assert
            Assert.AreEqual(expectedIndex7, myList[7]);
        }
        [TestMethod]
        public void ResizeHelper_OrginalPOW3_intsAdded() // array of size 4 should now become 64
        {
            //Arrange
            List_Custom<int> myList = new List_Custom<int>();
            int expectedIndex0 = 10;
            int expectedIndex1 = 5;
            int expectedIndex2 = 3;
            int expectedIndex3 = 2;
            int expectedIndex4 = 7;
            int expectedIndex5 = 8;
            int expectedIndex6 = 9;
            int expectedIndex7 = 10;
            int expectedIndex8 = 11;
            int expectedIndex9 = 12;
            int expectedIndex10 = 13;
            int expectedIndex11 = 14;
            int expectedIndex12 = 15;
            int expectedIndex13 = 16;

            //Act
            myList.cAdd(expectedIndex0);
            myList.cAdd(expectedIndex1);
            myList.cAdd(expectedIndex2);
            myList.cAdd(expectedIndex3);
            myList.cAdd(expectedIndex4);
            myList.cAdd(expectedIndex5);
            myList.cAdd(expectedIndex6);
            myList.cAdd(expectedIndex7);
            myList.cAdd(expectedIndex8);
            myList.cAdd(expectedIndex9);
            myList.cAdd(expectedIndex10);
            myList.cAdd(expectedIndex11);
            myList.cAdd(expectedIndex12);
            myList.cAdd(expectedIndex13);

            //Assert
            Assert.AreEqual(expectedIndex13, myList[13]);
            
        }







    }
}
