using System;
using System.Collections.Generic;

namespace CollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Printing List Values");
            usingList();

            Console.WriteLine("\nPrinting SortedList Key and Values");
            usingSortedList();

            Console.WriteLine("\nPrinting Hashset Values");
            usingHashSet();

            Console.WriteLine("\nPrinting Sortedset Values");
            usingSortedSet();

            Console.WriteLine("\nPrinting Stack Values");
            usingStack();

            Console.WriteLine("\nPrinting Queue Values");
            usingQueue();

            Console.WriteLine("\nPrinting LinkedList Values");
            usingLinkedList();

            Console.WriteLine("\nPrinting Dictionary Values");
            usingDictionary();

            Console.WriteLine("\nPrinting SortedDictionary Values");
            usingSortedDictionary();

        }


        static void usingList()
        {
            var names = new List<string>();
            names.Add("maruf");
            names.Add("maruf1");
            names.Add("maruf2");
            names.Add("maruf3");
            //Printing List using ForEach expression
            names.ForEach(x =>
            {
                Console.WriteLine(x);
            });

            //Printing List using ForEach Loop
            foreach (string s in names)
            {
                Console.WriteLine(s);
            }
            names.Remove("maruf3");
        }
        static void usingSortedList()
        {
            //Sorted as key and doesn't allow duplicate keys
            SortedList<string, Object> sortedList = new SortedList<string, Object>();
            sortedList.Add("1", "ankit");
            sortedList.Add("4", "Abdullah");
            sortedList.Add("5", "ankit");
            sortedList.Add("2", "sharif");
            sortedList.Add("3", "mohammad");
            sortedList.Add("6", "Kapil");

            //Printing SortedList using ForEach Loop
            foreach (KeyValuePair<string, Object> items in sortedList)
            {
                Console.WriteLine(items.Key + " - " + items.Value);
            }
        }
        static void usingHashSet()
        {
            //Doesn't allow duplicates
            HashSet<string> set = new HashSet<string>();
            set.Add("ankit");
            set.Add("sharif");
            set.Add("mohammad");
            set.Add("Abdullah");
            set.Add("ankit");
            set.Add("Kapil");

            //Printing HashSet using ForEach Loop
            foreach (string items in set)
            {
                Console.WriteLine(items);
            }
        }

        static void usingSortedSet()
        {
            //sorted and doesn't allow duplicates
            SortedSet<string> sortedSet = new SortedSet<string>();
            sortedSet.Add("ankit");
            sortedSet.Add("sharif");
            sortedSet.Add("mohammad");
            sortedSet.Add("Abdullah");
            sortedSet.Add("ankit");
            sortedSet.Add("Kapil");

            //Printing SortedSet using ForEach Loop
            foreach (string items in sortedSet)
            {
                Console.WriteLine(items);
            }
        }

        static void usingStack()
        {
            //Allows duplicate and Follows Last in First Out Approach
            Stack<string> stack = new Stack<string>();
            stack.Push("maruf");
            stack.Push("arman");
            stack.Push("foysal");
            stack.Push("nijam");

            Console.WriteLine("First name to peek : " + stack.Peek());
            Console.WriteLine("First name to pop : " + stack.Pop());
            Console.WriteLine("Second name to peek : " + stack.Peek());
            Console.WriteLine("Second name to pop : " + stack.Pop());

        }
        static void usingQueue()
        {
            //Allows duplicate and Follows First in First Out Approach
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("maruf");
            queue.Enqueue("arman");
            queue.Enqueue("foysal");
            queue.Enqueue("nijam");

            Console.WriteLine("First name to peek : " + queue.Peek());
            Console.WriteLine("First name to deQueue : " + queue.Dequeue());
            Console.WriteLine("Second name to peek : " + queue.Peek());
            Console.WriteLine("Second name to deQueue : " + queue.Dequeue());
        }

        static void usingLinkedList()
        {
            //allows duplicate
            //adds value node wise
            LinkedList<string> linkedList = new LinkedList<string>();

            linkedList.AddLast("Maruf");
            linkedList.AddLast("Peter");
            linkedList.AddLast("John");
            linkedList.AddLast("Abdullah");
            linkedList.AddFirst("Joseph");

            foreach (string names in linkedList)
            {
                Console.WriteLine(names);
            }
            Console.WriteLine("\nCreating New Node in Linked List");

            LinkedListNode<string> node = linkedList.Find("John");
            linkedList.AddBefore(node, "David");
            linkedList.AddAfter(node, "Harley");

            foreach (string names in linkedList)
            {
                Console.WriteLine(names);
            }
        }
        static void usingDictionary()
        {
            //Use Hashtable Concept
            //Stores Key value pair
            //Doesn't Allow duplicate keys
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("1","Oil");
            dictionary.Add("2","Shampoo");
            dictionary.Add("3","Lotion");
            dictionary.Add("4","Face Wash");

            foreach (KeyValuePair<string,object> item in dictionary)
            {
                Console.WriteLine(item.Key+" - "+ item.Value);
            }
        }
        static void usingSortedDictionary()
        {
            //Use Hashtable Concept
            //Stores Key value pair
            //Doesn't Allow duplicate keys
            //Sort ascending
            SortedDictionary<string, object> sortedDictionary = new SortedDictionary<string, object>();
            sortedDictionary.Add("1","Oil");
            sortedDictionary.Add("3","Lotion");
            sortedDictionary.Add("4","Face Wash");
            sortedDictionary.Add("2","Shampoo");

            foreach (KeyValuePair<string,object> item in sortedDictionary)
            {
                Console.WriteLine(item.Key+" - "+ item.Value);
            }
        }
    }
}
