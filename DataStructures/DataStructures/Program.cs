using System;
using DataStructures.LinkedList;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the data structure project");

            Console.WriteLine("Adding 4 items to the structure");

            LinkedList.LinkedList<String> list = new LinkedList.LinkedList<String>();

            list.Insert(new Node<String>("Test1"));
            list.Insert(new Node<String>("Test2"));
            list.Insert(new Node<String>("Test3"));
            list.Insert(new Node<String>("Test4"));

            list.PrintNodeList();

            list.Delete(new Node<string>("Test2"));

            list.PrintNodeList();

            list.RecursiveSearch("Test3");

            Console.ReadLine();
        }
    }
}
