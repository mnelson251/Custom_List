using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class AddMethodTest
    {
        [TestMethod]
        
        public void AddMethod_intAdded() // cAdd method adds to list?
        {
            //Arrange
            List_Custom<int> myList = new List_Custom<int>();
            int expectedResult = 10;

            //Act
            myList.Add(expectedResult);

            //Assert
            Assert.AreEqual(expectedResult, myList[0]);

        }

        [TestMethod]
        public void Placement_intAdded() // upon adding an ojb - correct place?
        {
            //Arrange
            List_Custom<int> myList = new List_Custom<int>();
            int expectedResult = 10;
            int expectedResult2 = 5;

            //Act
            myList.Add(expectedResult);
            myList.Add(expectedResult2);

            //Assert
            Assert.AreEqual(expectedResult, myList[0]); 

        }

        [TestMethod]
        public void PlacementIndex_intAdd() // upon adding a second object - correct placement ??
        {
            //Arrange
            List_Custom<int> myList = new List_Custom<int>();
            int expectedResult = 10;
            int expectedResult2 = 5;

            //Act
            myList.Add(expectedResult);
            myList.Add(expectedResult2);

            //Assert
            Assert.AreEqual(expectedResult2, myList[1]); 

        }

        [TestMethod]
        public void PlacementIndex_thirdPlace_intAdded() // upon adding a third object - correct placement ??
        {
            //Arrange
            List_Custom<int> myList = new List_Custom<int>();
            int expectedResult = 10;
            int expectedResult2 = 5;
            int expectedResult3 = 3;

            //Act
            myList.Add(expectedResult);
            myList.Add(expectedResult2);
            myList.Add(expectedResult3);

            //Assert
            Assert.AreEqual(expectedResult3, myList[2]); 

        }

        [TestMethod]
        public void PlacementSpecific_intAdded() // with multi objects in list - correct placement of index 2 ??
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
            myList.Add(expectedIndex0);
            myList.Add(expectedIndex1);
            myList.Add(expectedIndex2);
            myList.Add(expectedIndex3);
            myList.Add(expectedIndex4);
            myList.Add(expectedIndex5);

            //Assert
            Assert.AreEqual(expectedIndex3, myList[3]);

        }
        


    }
}
