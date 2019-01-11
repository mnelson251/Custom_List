using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    
    [TestClass]
    public class RemoveMethod
    {
        [TestMethod]
        public void cRemove_SingleEntry_EmpytList() // if an object is removed, does count reflect
        {
            //Arrange
            List_Custom<int> testItem = new List_Custom<int>();

            int expectedResult = 10;

            //Act
            testItem.cAdd(expectedResult);   // need something in there first
            
            testItem.cRemove(expectedResult); // take that thing out again

            //Assert
            Assert.AreEqual(0, testItem.count);

        }

        [TestMethod]
        public void cRemoveBeforeShift_ints_NullValueAtIndex()
            {
             //Arrange
             List_Custom<int> testItem = new List_Custom<int>();

                int expectedResult = 10;
                int expectedResult1 = 20;
                int expectedResult2 = 40;
                int expectedResult3 = 60;
            
            //if the last index of the array is removed is its value now set to zero?

             //Act
              testItem.cAdd(expectedResult);
              testItem.cAdd(expectedResult1);
              testItem.cAdd(expectedResult2);
              testItem.cAdd(expectedResult3);
             // test
              testItem.cRemove(expectedResult3); 

             //Assert
             Assert.AreEqual( null , testItem[3]);

            }

        [TestMethod]
        public void cRemove_ints_ValuesAreNotEqual()
        {
            //Arrange
            List_Custom<int> testItem = new List_Custom<int>();

            int expectedResult0 = 10;
            int expectedResult1 = 20;
            int expectedResult2 = 40;
            int expectedResult3 = 60;

            //Act
            testItem.cAdd(expectedResult0);
            testItem.cAdd(expectedResult1);
            testItem.cAdd(expectedResult2);
            testItem.cAdd(expectedResult3);
            // test
            testItem.cRemove(expectedResult0);

            //Assert
            Assert.IsFalse(expectedResult0 == testItem[0]); 
            // after I remove the index 0, it should not equal whats now at index 0
            
        }

        [TestMethod]
        public void cRemove_RemoveMultiStrings_AllLikeStringsRemoved()
        {
            //Arrange
            List_Custom<string> testItem = new List_Custom<string>();

            string expectedResult0 = "I";
            string expectedResult1 = "love";
            string expectedResult2 = "am";
            string expectedResult3 = "love";
            string expectedResult4 = "indifferent";

            //Act
            testItem.cAdd(expectedResult0);
            testItem.cAdd(expectedResult1);
            testItem.cAdd(expectedResult2);
            testItem.cAdd(expectedResult3);
            testItem.cAdd(expectedResult4);
            // test
            testItem.cRemove("love");

            //Assert
            Assert.AreEqual(3, testItem.count);
            // function needs to loop through entire legth of array
            // and remove all instances of the parameter passed

        }


    }
}
