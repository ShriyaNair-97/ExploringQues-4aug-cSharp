using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    class LinkedList
    {
        static void Main() { 
        LinkedList<string> myList = new LinkedList<string>();
            myList.AddLast("Panipuri");
            myList.AddLast("Sandwich");
            myList.AddLast("Burger");
            myList.AddLast("Chole_kulche");
            myList.AddLast("Pizza");
            Console.WriteLine("Adding pasta at the first node using AddFirst()");
            myList.AddFirst("Pasta");
            LinkedListNode<string> n1 = myList.Find("Pizaa");

            LinkedListNode<string> var1 = myList.AddAfter(n1, "Panipuri");
            myList.AddBefore(var1, "Chole_kulche");
            
            foreach(string str in myList)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("Iteration using GetEnumerator method");

            LinkedList<string>.Enumerator lle = myList.GetEnumerator();
            while (lle.MoveNext())
            {
                Console.WriteLine(lle.Current);
               
            }
            Console.WriteLine("Contains Method--------");
                 bool ht = myList.Contains("Satara");
            Console.WriteLine(ht);
                Console.WriteLine("Using CopytTo method------------");
                string[] arr = new string[myList.Count];

            myList.CopyTo(arr,0);
            foreach (string item in arr)
            {
                Console.WriteLine(item);
            }

            LinkedListNode<string> b = myList.FindLast("Sandwich");

            Console.WriteLine("FindLast method:{0}",b.Value);
            bool rem = myList.Remove("Pizza");

            Console.WriteLine("Removing Element Pizza from the linked list:{0}",rem );

            foreach (string show in myList)
            {
                Console.WriteLine(show);
            }

            Console.WriteLine("Removing the starting node from the linked list");
            myList.RemoveFirst();
            foreach (string rem1 in myList)
            {
                Console.WriteLine(rem1);
            }

            Console.WriteLine("Removing the node at the last from the linked list");
            myList.RemoveLast();
            foreach(string disp in myList)
            {
                Console.WriteLine(disp);
            }
          
            Console.Read();

 

        }
    }
}
