using System;

namespace LinkedListCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyNode myFirstNode;
            MyNode mySecondNode;
            MyNode myThirdNode;
            myFirstNode = new MyNode(70);
            mySecondNode = new MyNode(30);
            myThirdNode = new MyNode(56);
            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.Add(myFirstNode);
            myLinkedList.Add(mySecondNode);
            myLinkedList.Add(myThirdNode);
            myLinkedList.printMyNodes();
        }
    }
}
