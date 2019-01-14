using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{

    [TestClass]
    public class RemoveMethodTest
    {
        [TestMethod]
        public void cRemove_CheckArrayCount_EmpytList() // if an object is removed, does count reflect
        {
            //Arrange
            List_Custom<int> testItem = new List_Custom<int>();
            int intToBeEntererd = 10;
            int expectedValue = 0;
            //Act
            testItem.Add(intToBeEntererd);
            testItem.cRemove(intToBeEntererd);
            //Assert
            Assert.AreEqual(expectedValue, testItem.count);
        }

        //[TestMethod]
        //public void cRemove_ProperIndexRemoved_NullValueAtIndex()
        //{
        //    //Arrange
        //    List_Custom<int> testItem = new List_Custom<int>();
        //    int expectedResult = 10;
        //    int expectedResult1 = 20;
        //    int expectedResult2 = 40;
        //    int expectedResult3 = 60;
        //    //if the last index of the array is removed is its value now set to zero?
        //    //Act
        //    testItem.cAdd(expectedResult);
        //    testItem.cAdd(expectedResult1);
        //    testItem.cAdd(expectedResult2);
        //    testItem.cAdd(expectedResult3);
        //    testItem.cRemove(expectedResult3);
        //    //Assert
        //    Assert.IsNull(testItem[3]);
        //    //after index is removed, because the array will not be resized
        //}

        [TestMethod]
        public void cRemove_RemoveIndexNotEqualToIndex_ValuesAreNotEqual()
        {
            //Arrange
            List_Custom<int> testItem = new List_Custom<int>();
            int expectedResult0 = 10;
            int expectedResult1 = 20;
            int expectedResult2 = 40;
            int expectedResult3 = 60;
            //Act
            testItem.Add(expectedResult0);
            testItem.Add(expectedResult1);
            testItem.Add(expectedResult2);
            testItem.Add(expectedResult3);
            testItem.cRemove(expectedResult0);
            //Assert
            Assert.IsFalse(expectedResult0 == testItem[0]);
            // after I remove the index 0, it should not equal whats now at index 0
            // not a very testy test - 

        }

        [TestMethod]
        public void cRemove_RemoveMultiStrings_OnlyOneStringRemoved()
        {
            //Arrange
            List_Custom<string> testItem = new List_Custom<string>();
            string expectedResult0 = "I";
            string expectedResult1 = "love";
            string expectedResult2 = "am";
            string expectedResult3 = "love";
            string expectedResult4 = "indifferent";
            //Act
            testItem.Add(expectedResult0);
            testItem.Add(expectedResult1);
            testItem.Add(expectedResult2);
            testItem.Add(expectedResult3);
            testItem.Add(expectedResult4);
            testItem.cRemove("love");
            //Assert
            Assert.AreEqual(4, testItem.count);
            // function needs to loop through entire legth of array
            // and remove all instances of the parameter passed
        }

        [TestMethod]
        public void cRemove_RemoveInstanceOfString_RemovedInstanceArrayShifted()
        {

            //Arrange
            List_Custom<string> testItem = new List_Custom<string>();
            string ToBeEntered0 = "I";
            string ToBeEntered1 = "love";
            string ToBeEntered2 = "am";
            string ToBeEntered3 = "love";
            string ToBeEntered4 = "indifferent";
            string expectedString = "love";
            //Act
            testItem.Add(ToBeEntered0);
            testItem.Add(ToBeEntered1);
            testItem.Add(ToBeEntered2);
            testItem.Add(ToBeEntered3);
            testItem.Add(ToBeEntered4);
            testItem.cRemove("love");
            //Assert
            Assert.AreEqual(expectedString, testItem[2]);
            // after removing one instance of string, did all the other strings shift?
            // is there still other strings like the one i just removed?
        }





    }
}
