using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class List_Custom <T> 
    {

        public int count;
        public int capacity;
        public bool CompareValues;
        public int returnedType;


        T[] myList;

        public List_Custom()
        {
            capacity = 4;
            myList = new T[capacity];
        }

        public int value { get; private set; }

        public T this[int index] 
        {
            get => myList[index];
            protected set => myList[index] = value;
        }

        public void cResizeCondition()
        {
            //CompareValues = (capacity == count);
            if (capacity == count)
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
            count++;
            cResizeCondition();
            myList[count - 1] = input;
            
        }

        public void cRemove(T input) //method removes from list
        {
            
            for (int i = 0; i < myList.Length; i++) 
            {

                //int NewCount = myList.Length;


                if (myList[i].Equals(input))
                {
                    //count--;

                    myList[i] = default(T);
                    
                    for (int j = 0; j < myList.Length; i++)
                    {

                        myList[i] = myList[i + 1];
                    }

                    int lastPlace;
                    lastPlace = myList.Length - 1;
                    lastPlace = default(int);
                   
                }

            }

        }

        public void cCount(T item) //method counts list
        {


        }

       

    }
}
