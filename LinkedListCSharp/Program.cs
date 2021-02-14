using System;

namespace LinkedListCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List");

            MyLinkedList myLinkedList = new MyLinkedList();
            MyNode myFirstNode = new MyNode(56);
            MyNode mySecondNode = new MyNode(30);
            MyNode myThirdNode = new MyNode(70);
            myLinkedList.Append(myFirstNode);
            myLinkedList.Append(mySecondNode);
            myLinkedList.Append(myThirdNode);
            myLinkedList.PrintMyNodes();
        }
    }
}
