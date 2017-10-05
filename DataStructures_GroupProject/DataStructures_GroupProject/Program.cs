//This program was prepared by Tomiris Mollinet
//IS 403 Section 001
// Descroption: This program will help me familiarize myself with various data structures available in the C# language.
//I am the owner of a very successful hamburger restaurant. MY faithful customers line up every day and eat dozens of burgers.
//I am writing a program to track exactly how many hamburgers each customer eats.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_GroupProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            int choice = 0;
            int i = 0;
            string delete;
            int size;
            int j;
            string response;
            Stack<string> myStack = new Stack<string>();
            Queue<string> myQueue = new Queue<string>();
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            TimeSpan timeElapsed;



            while (answer != 4)
                {
                Console.Write("\nChoose from the following:\n1.Stack\n2.Queue\n3.Dictionary\n4.Exit\n\n");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == 1)
                {
                    choice = 0;
                    while (choice != 7)
                    {
                        Console.WriteLine("\n\nChoose from the following:\n\n1. Add one item to Stack\n2.Add Huge List of Items to Stack\n3.Display Stack\n4.Delete from Stack\n5.Clear Stack\n6.Search Stack\n7.Return to Main Menu\n");
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)
                        {
                            Console.WriteLine("\nWhat would you like to add?\n");
                            myStack.Push(Console.ReadLine());
                        }
                        else if (choice == 2)

                        {
                            myStack.Clear();
                            for (i = 0; i< 2000; i++)
                            {
                                myStack.Push("New Entry " + (i + 1));
                            }
                           
                        }
                        else if (choice == 3)
                        {
                            Console.WriteLine();
                            foreach(string item in myStack)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        else if (choice == 4)
                        {
                            Stack<string> tempStack = new Stack<string>();
                            Console.WriteLine("\nWhich item would you like to delete?\n");
                            delete = Console.ReadLine();
                            size = myStack.Count;
                            for (i = 0; i < size; i++)
                            {
                                if (delete == myStack.Peek())
                                {
                                    myStack.Pop();
                                }
                                else
                                {
                                    tempStack.Push(myStack.Pop());
                                }
                            }
                            int length = tempStack.Count;
                            for (j = 0; j < length; j++)
                            {
                                myStack.Push(tempStack.Pop());
                            }
                        }
                        else if (choice == 5)
                        {
                            myStack.Clear();
                        }
                        else if (choice == 6)
                        {
                            Console.WriteLine("\nWhat would you like to search for?\n");
                            string searchText = Console.ReadLine();
                            sw.Start();
                                if(myStack.Contains(searchText))
                                {
                                    Console.WriteLine("\nYou found it!!!\n");
                                }
                                else
                                {
                                    Console.WriteLine("\nItem was not found\n");
                                }
                            sw.Stop();
                            timeElapsed = sw.Elapsed;
                            Console.WriteLine("Total elapsed time: " + timeElapsed);
                            }
                        else
                        {
                            choice = 7;
                        }

                    }
                }

                else if (answer == 2)
                {
                    choice = 0;
                    while (choice != 7)
                    {
                        Console.WriteLine("\n\nChoose from the following:\n\n1. Add one item to Queue\n2.Add Huge List of Items to Queue\n3.Display Queue\n4.Delete from Queue\n5.Clear Queue\n6.Search Queue\n7.Return to Main Menu\n");
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)
                        {
                            Console.WriteLine("\nWhat would you like to add?\n");
                            myQueue.Enqueue(Console.ReadLine());
                        }
                        else if (choice == 2)

                        {
                            myQueue.Clear();
                            for (i = 0; i < 2000; i++)
                            {
                                myQueue.Enqueue("New Entry " + (i + 1));
                            }

                        }
                        else if (choice == 3)
                        {
                            Console.WriteLine();
                            foreach (string item in myQueue)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        else if (choice == 4)
                        {
                            Queue<string> tempQueue = new Queue<string>();
                            Console.WriteLine("\nWhich item would you like to delete?\n");
                            delete = Console.ReadLine();
                            size = myQueue.Count;
                            for (i = 0; i < size; i++)
                            {
                                if (delete == myQueue.Peek())
                                {
                                    myQueue.Dequeue();
                                }
                                else
                                {
                                    tempQueue.Enqueue(myQueue.Dequeue());
                                }
                            }
                            int length = tempQueue.Count;
                            for (j = 0; j < length; j++)
                            {
                                myQueue.Enqueue(tempQueue.Dequeue());
                            }
                        }
                        else if (choice == 5)
                        {
                            myQueue.Clear();
                        }
                        
                        else if (choice == 6)
                        {
                            Console.WriteLine("\nWhat would you like to search for?\n");
                            string searchText = Console.ReadLine();
                            sw.Start();
                            if (myQueue.Contains(searchText))
                            {
                                Console.WriteLine("\nYou found it!!!\n");
                            }
                            else
                            {
                                Console.WriteLine("\nItem was not found\n");
                            }
                            sw.Stop();
                            timeElapsed = sw.Elapsed;
                            Console.WriteLine("Total elapsed time: " + timeElapsed);
                        }
                        else
                        {
                            choice = 7;
                        }

                    }
                }
                else if (answer == 3)
                {
                    choice = 0;
                    while (choice != 7)
                    {
                        Console.WriteLine("\n\nChoose from the following:\n\n1. Add one item to Dictionary\n2.Add Huge List of Items to Dictionary\n3.Display Dictionary\n4.Delete from Dictionary\n5.Clear Dictionary\n6.Search Dictionary\n7.Return to Main Menu\n");
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)
                        {
                            Console.WriteLine("\nWhat would you like to add?\n");
                            response = Console.ReadLine();
                            myDictionary.Add(response, 1);
                        }
                        else if (choice == 2)

                        {
                            myDictionary.Clear();
                            for (i = 0; i < 2000; i++)
                            {
                                myDictionary.Add(("New Entry " + (i+1)), 1);
                            }

                        }
                        else if (choice == 3)
                        {
                            Console.WriteLine();
                            foreach (KeyValuePair<string, int> entry in myDictionary)
                            {
                                Console.WriteLine(entry.Key);
                            }
                        }
                        else if (choice == 4)
                        {
                            Dictionary<string, int> tempDictionary = new Dictionary<string, int>();
                            Console.WriteLine("\nWhich item would you like to delete?\n");
                            delete = Console.ReadLine();
                            size = myDictionary.Count;
                                if (myDictionary.ContainsKey(delete))
                                {
                                    myDictionary.Remove(delete);
                                }
                                else
                                {
                                    Console.WriteLine("Item does not exist in the dictionary");
                                }
                         }
                        else if (choice == 5)
                        {
                            myDictionary.Clear();
                        }
                        else if (choice == 6)
                        {
                            Console.WriteLine("\nWhat would you like to search for?\n");
                            string searchText = Console.ReadLine();
                            sw.Start();
                            if (myDictionary.ContainsKey(searchText))
                            {
                                Console.WriteLine("\nYou found it!!!\n");
                            }
                            else
                            {
                                Console.WriteLine("\nItem was not found\n");
                            }
                            sw.Stop();
                            timeElapsed = sw.Elapsed;
                            Console.WriteLine("Total elapsed time: " + timeElapsed);
                        }
                        else
                        {
                            choice = 7;
                        }

                    }
                }

                else
                {
                    answer = 4;
                }
            }

        }
    }
}
