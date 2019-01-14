using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class ToStringOverRideTest
    {
        [TestMethod]
        public void OverR2String_Int2String_StringValue()
        {
            //Arrange
            List_Custom<int> myList = new List_Custom<int>();
            int IntAt0 = 2;
            int IntAt1 = 4;
            int IntAt2 = 6;
            int IntAt3 = 8;
            string StringedList = " 2, 4, 6, 8, ";
            //Act
            myList.Add(IntAt0);
            myList.Add(IntAt1);
            myList.Add(IntAt2);
            myList.Add(IntAt3);
            string outcome = myList.ToString();
            //Assert
            Assert.AreEqual( outcome, StringedList);
            //Test compares if to string method stringifies intigers
            //by comparing the method results with a hardcoded version
        }

        //[TestMethod]
        //public void overR2String_String2String_StringValue()
        //{
        //    //Arrange
        //    List_Custom<string> myList = new List_Custom<string>();
        //    int ValAt0 = "2";
        //    int IntAt1 = "4";
        //    int IntAt2 = "6";
        //    int IntAt3 = "8";
        //    string IntAt1String = "4";


        //}

        //[TestMethod]
        //public void OverR2String_OverL2String_TwovalueString()

        //{
        //    //Arrange
        //    List_Custom<int> myList = new List_Custom<int>();
        //    int IntAt0 = 2;
        //    int IntAt1 = 4;
        //    int IntAt2 = 6;
        //    int IntAt3 = 8;
        //    string StringInts = "4 6";
        //    //Act
        //    myList.cAdd(IntAt0);
        //    myList.cAdd(IntAt1);
        //    myList.cAdd(IntAt2);
        //    myList.cAdd(IntAt3);
        //    string TwoValueString = myList.cToString(IntAt1, IntAt2);
        //    //Assert
        //    Assert.AreEqual(StringInts, TwoValueString);
        //    //cToString2 method takes in two arguments, stringifies them, then 
        //    // puts them together

        //}




    }
}
