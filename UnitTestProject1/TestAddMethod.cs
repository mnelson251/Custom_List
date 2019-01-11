using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class TestAddMethod
    {
        [TestMethod]
        
        public void cAddMethod_UNK_valueAdded() // cAdd method adds to list?
        {
            //Arrange
            List_Custom<int> myList = new List_Custom<int>();
            int expectedResult = 10;

            //Act
            myList.cAdd(expectedResult);

            //Assert
            Assert.AreEqual(expectedResult, myList[0]);

        }

        [TestMethod]
        public void cAddPlacement_UNK_valueAdded() // upon adding an ojb - correct place?
        {
            //Arrange
            List_Custom<int> myList = new List_Custom<int>();
            int expectedResult = 10;
            int expectedResult2 = 5;

            //Act
            myList.cAdd(expectedResult);
            myList.cAdd(expectedResult2);

            //Assert
            Assert.AreEqual(expectedResult, myList[0]); 

        }

        [TestMethod]
        public void cAddPlacementTWO_UNK_valueAdded() // upon adding a second object - correct placement ??
        {
            //Arrange
            List_Custom<int> myList = new List_Custom<int>();
            int expectedResult = 10;
            int expectedResult2 = 5;

            //Act
            myList.cAdd(expectedResult);
            myList.cAdd(expectedResult2);

            //Assert
            Assert.AreEqual(expectedResult2, myList[1]); 

        }

        [TestMethod]
        public void cAddPlacementTHREE_UNK_valueAdded() // upon adding a third object - correct placement ??
        {
            //Arrange
            List_Custom<int> myList = new List_Custom<int>();
            int expectedResult = 10;
            int expectedResult2 = 5;
            int expectedResult3 = 3;

            //Act
            myList.cAdd(expectedResult);
            myList.cAdd(expectedResult2);
            myList.cAdd(expectedResult3);

            //Assert
            Assert.AreEqual(expectedResult3, myList[2]); 

        }

        [TestMethod]
        public void cAddPlacementSpecific_UNK_valueAdded() // with multi objects in list - correct placement of index 2 ??
        {
            //Arrange
            List_Custom<int> myList = new List_Custom<int>();
            int expectedIndex0 = 10;
            int expectedIndex1 = 5;
            int expectedIndex2 = 3;
            int expectedIndex3 = 2;
            int expectedIndex4 = 7;
            int expectedIndex5 = 8;

            //Act
            myList.cAdd(expectedIndex0);
            myList.cAdd(expectedIndex1);
            myList.cAdd(expectedIndex2);
            myList.cAdd(expectedIndex3);
            myList.cAdd(expectedIndex4);
            myList.cAdd(expectedIndex5);

            //Assert
            Assert.AreEqual(expectedIndex3, myList[3]);

        }



    }
}
