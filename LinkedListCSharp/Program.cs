using System;

namespace LinkedListCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List");

            MyNode myFirstNode = new MyNode(56);
            MyNode mySecondNode = new MyNode(30);
            MyNode myThirdNode = new MyNode(70);
            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.Append(myFirstNode);
            myLinkedList.Append(mySecondNode);
            myLinkedList.Append(myThirdNode);
            myLinkedList.Pop();
            myLinkedList.PrintMyNodes();
        }
    }
}
