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
            //Arrage
            List_Custom<int> list1 = new List_Custom<int>() { 2, 4, 6 };
            List_Custom<int> list2 = new List_Custom<int>() { 3, 5, 7 };
            List_Custom<int> list3 = new List_Custom<int>();
            //Act
            list3.Zipper(list1, list2);
            //Assert
            Assert.AreEqual(list3[3], list2[1]); 
        }

        [TestMethod]
        public void Zipper_OmitsNullValuesAtEnd_Yes()
        {
            //Arrage
            List_Custom<int> list1 = new List_Custom<int>() { 0, 4, 6 };
            List_Custom<int> list2 = new List_Custom<int>() { 3, 5, 7 };
            List_Custom<int> list3 = new List_Custom<int>();
            //Act
            list3.Zipper(list1, list2);
            //Assert
            Assert.AreEqual(list3[3], list2[1]);




        }

        [TestMethod]
        public void Zipper_OmitsNullValsAtBegining_Yes()
        {




        }

        [TestMethod]
        public void Zipper_3()
        {




        }



    }
}
