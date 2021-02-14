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
            MyNode myThirdNode = new MyNode(40);
            MyNode myFourthNode = new MyNode(70);

            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.Add(mySecondNode);
            myLinkedList.Add(myFirstNode);
            myLinkedList.Append(myFourthNode);
            myLinkedList.Search(mySecondNode);
            myLinkedList.PrintMyNodes();
            myLinkedList.Insert(mySecondNode, myThirdNode);
            myLinkedList.PrintMyNodes();
        }
    }
}
