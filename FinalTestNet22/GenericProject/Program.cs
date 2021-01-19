using System;
using System.Collections.Generic;

namespace GenericProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write a generic class that meets the following requirements:
1)    That constrains a developer to only instantiate the class based on value types
2)    Contains a private generic collection
3)    Has a method to add items to the private collection
4)    Has a method that will return an  item from the list (e.g. item 3 or item 4 in the list)
5)    Has a method that returns a sorted collection with the items in descending order
             * */
        }
        public class ExampleClass<T> where T: struct
        {
            private List<T> privateList = new List<T>();
            public void AddItem(T val)
            {
                privateList.Add(val);
            }


        }
    }
}
