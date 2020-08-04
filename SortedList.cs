using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    class SortedList
    {
        static void Main()
        {
            SortedList<int, string> sortedList = new SortedList<int, string>();
            sortedList.Add(1, "Hello");
            sortedList.Add(2, "Everyone");
            sortedList.Add(3, "How");
            sortedList.Add(4, "Are");
            sortedList.Add(5, "You");
            sortedList.Add(6, "All??");
            Console.WriteLine("Elements of SortedList are");

            foreach (KeyValuePair<int, string> item in sortedList)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }

            int sl1 = sortedList.IndexOfValue("Are");
            Console.WriteLine("The index of Are is :{0}", sl1);
            
            Console.WriteLine("The no of elements the SortedList contains:{0}", sortedList.Capacity);

            Console.WriteLine("Count of the key value pairs in the  SortedList is:{0}", sortedList.Count);

            Console.WriteLine("Getting all the values in the SortedList");

            foreach (string item2 in sortedList.Values)
            {
                Console.WriteLine(item2);
            }
            Console.WriteLine("Getting keys from the SortedList");
            foreach (int item3 in sortedList.Keys)
            {
                Console.WriteLine(item3);
            }

            Console.WriteLine("ContainsKey method-----------");
            bool a = sortedList.ContainsKey(9);

            Console.WriteLine("Contains Key true or false:{0}", a);

            Console.WriteLine("ContainsValue method------------");
            bool b = sortedList.ContainsValue("Everyone");

            Console.WriteLine("Contains the value true or false:{0}", b);
            int key = sortedList.IndexOfKey(6);

            Console.WriteLine("The index of the key 6 is :{0}", key);
            int value = sortedList.IndexOfValue("Hello");

            Console.WriteLine("The index of the value HELLO is:{0}", value);

            Console.WriteLine("Removing the element with key 6:{0}", sortedList.Remove(6));

            foreach (KeyValuePair<int, string> kv in sortedList)
            {
                Console.WriteLine(kv);
            }
            Console.WriteLine("Removing element from the index 2:");
            sortedList.RemoveAt(2);
            foreach (KeyValuePair<int, string> k in sortedList)
            {
                Console.WriteLine(k);
            }

            Console.Read();
        }
    }
    }
}
