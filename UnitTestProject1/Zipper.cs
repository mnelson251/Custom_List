using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    
    [TestClass]
    public class Zipper
    {

        [TestMethod]
        public void Zipper_ThreadedList_Yes()
        {
            //Arrange
            List_Custom<int> list1 = new List_Custom<int>() { 2, 4, 6 };
            List_Custom<int> list2 = new List_Custom<int>() { 3, 5, 7 };
            List_Custom<int> list3 = new List_Custom<int>();
            //Act
            list3 = list1.Zipper(list2);
            //Assert
            Assert.AreEqual(list3[3], list2[1]); 
        }

        [TestMethod]
        public void Zipper_StringInputs_StringsZippedUp()
        {
            //Arrange
            List_Custom<string> list1 = new List_Custom<string>() { "Who", "carry", "boats" };
            List_Custom<string> list2 = new List_Custom<string>() { "will", "the", "?" };
            List_Custom<string> list3 = new List_Custom<string>();
            //Act
            list3 = list1.Zipper(list2);
            //Assert
            Assert.AreEqual(list3[4], list1[2]);
        }

        [TestMethod]
        public void Zipper_CharInputsToBeZipped_ZippedChars()
        {
            //Arrange
            List_Custom<char> list1 = new List_Custom<char>() { 'C', 'N', ' ', 'U', 'T', 'M',};
            List_Custom<char> list2 = new List_Custom<char>() { 'A', 'T', 'H', 'R', ' ', 'E'  }
            List_Custom<char> list3 = new List_Custom<char>();
            //Act
            list3 = list1.Zipper(list2);
            //Assert
            Assert.AreEqual(list3[4], list2[4]);
        }

        [TestMethod]
        public void Zipper_List3Count_CountIsSumofZippedLists()
        {
            //Arrange
            List_Custom<int> list1 = new List_Custom<int>() { 2, 4, 6 };
            List_Custom<int> list2 = new List_Custom<int>() { 3, 5, 7 };
            List_Custom<int> list3 = new List_Custom<int>();
            //Act
            list3 = list1.Zipper(list2);
            Assert.AreEqual(6, list3.count);
        }



    }
}
