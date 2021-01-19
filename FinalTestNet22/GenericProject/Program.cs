using System;
using System.Collections.Generic;
using System.Linq;

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
            var ec = new ExampleClass<int>();
            ec.AddItem(3);
            ec.AddItem(2);
            ec.AddItem(1);
            Console.WriteLine($"Given order: {0},{1},{2}", ec.GetItem(0), ec.GetItem(1), ec.GetItem(2));
            var desSortList = ec.SortedCollection().ToList();
            Console.WriteLine($"Sorted : {0},{1},{2}", desSortList[0], desSortList[1], desSortList[2]);

        }
        public class ExampleClass<T> where T: struct
        {
            private List<T> privateList = new List<T>();
            public void AddItem(T val)
            {
                privateList.Add(val);
            }
            public T GetItem(int index)
            {
                return privateList[index];
            }

            public List<T> SortedCollection()
            {
                //IEnumerable<T> sc = privateList.OrderByDescending(x => x);                
                // return sc;
                privateList.Sort();
                return privateList;
            }

        }
    }
}
