using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CustomList
{
    public class List_Custom <T>
    {
        //readonly int count;
        int _count;
        public int capacity;
        public bool CompareValues;
        public int returnedType;
        public string StringedValues;
        public string ConvertedValue;
        T[] myList;

        public List_Custom()
        {
            capacity = 4;
            myList = new T[capacity];
        }

        public int value { get; private set; }

        public int count { get => _count; }

        public T this[int index] 
        {
            get => myList[index];
            protected set => myList[index] = value;
        }

        public void cResizeCondition()
        {
            if (capacity == _count)
            {
                capacity = capacity * 2;
                T[] newList = new T[capacity];
                for (int i = 0; i < myList.Length; i++)
                {
                    newList[i] = myList[i];
                }
                myList = newList;
            }
        }

        public void cAdd(T input) // method adds to list 
        {
            _count++;
            cResizeCondition();
            myList[_count - 1] = input;  
        }

        public void cRemove(T input) //method removes from list
        {
            for (int i = 0; i < myList.Length; i++) 
            {
                if (myList[i].Equals(input))
                {
                    myList[i] = default(T);
                    _count--;
                    for (int j = i; j < _count; j    ++)
                    {
                        myList[j] = myList[j + 1];
                    }
                    myList[_count] = default(T);
                    break;
                } 
            }
        }

        public void cCount(T item) //method counts list
        {


        }

        
        public override string ToString()
        {
            StringedValues = " ";
            for (int i = 0; i < _count; i++)
            {
                ConvertedValue = "" + myList[i] + ", ";
                StringedValues += ConvertedValue;
            }
            return StringedValues;
        }


    }
}
