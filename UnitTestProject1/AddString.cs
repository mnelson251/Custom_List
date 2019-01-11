﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class AddString
    {
        [TestMethod]
        public void Add_DataTypeString_DataTypeAdded()
        {

            //Arrange
            List_Custom<string> myList = new List_Custom<string>();
            string expectedResult = "Testing";

            //Act
            myList.cAdd(expectedResult);

            //Assert
            Assert.AreEqual(expectedResult, myList[0]);
        }

        [TestMethod]
        public void cAdd_Strings_CorrectIndex()
        {

            //Arrange
            List_Custom<string> myList = new List_Custom<string>();
            string expectedResult = "Testing";
            string expectedResult1 = "string";
            string expectedResult2 = "input";
            string expectedResult3 = ".";

            //Act
            myList.cAdd(expectedResult);
            myList.cAdd(expectedResult1);
            myList.cAdd(expectedResult2);
            myList.cAdd(expectedResult3);

            //Assert
            Assert.AreEqual(expectedResult3, myList[3]);
        }



    }
}
