using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListCSharp
{
    public class MyLinkedList
    {
		public MyNode head;
		public MyNode tail;

		public MyLinkedList()
		{
			this.head = null;
			this.tail = null;
		}

		/// <summary>
		/// UC-2 Create Add method 
		/// </summary>
		/// <param name="newNode"></param>
		public void Add(MyNode newNode)
		{
			if (this.tail == null)
			{
				this.tail = newNode;
			}

			if (this.head == null)
			{
				this.head = newNode;
			}
			else
			{
				MyNode tempNode = this.head;
				this.head = newNode;
				this.head.setNext(tempNode);
			}


		}
		/// <summary>
		/// UC-3 Create Append Method
		/// </summary>
		/// <param name="newNode"></param>
		public void Append(MyNode newNode)
		{
			if (this.head == null)
			{
				this.head = newNode;
			}
			if (this.tail == null)
			{
				this.tail = newNode;
			}
			else
			{
				MyNode tempNode = this.tail;
				this.tail = newNode;
				tempNode.setNext(newNode);
			}

		}
		/// <summary>
		/// UC-4 Create Insert method
		/// </summary>
		/// <param name="myNode"></param>
		/// <param name="newNode"></param>
		public void Insert(MyNode myNode, MyNode newNode)
		{
			MyNode tempNode = myNode.getNext();
			myNode.setNext(newNode);
			newNode.setNext(tempNode);
		}

		/// <summary>
		/// UC-5 Create pop method
		/// </summary>
		/// <returns></returns>
		public MyNode Pop()
		{
			MyNode tempNode = this.head;
			this.head = head.getNext();
			return tempNode;
		}

		/// <summary>
		/// UC-6 Create PopLast method
		/// </summary>
		/// <returns></returns>
		public MyNode PopLast()
		{
//			this.tail = null;
			MyNode tempNode = this.head;
//			tempNode = tempNode.getNext();
//			this.tail = tempNode;

			while (!tempNode.getNext().Equals(tail))
			{
				tempNode = tempNode.getNext();
			}
			this.tail = tempNode;
			tempNode = this.tail.getNext();
			tempNode = null;

			return tempNode;
		}

		/// <summary>
		/// UC-7 Create Search method
		/// </summary>
		/// <param name="myNode"></param>
		public void Search(MyNode myNode)
		{
			MyNode tempNode = head;
			while (tempNode.getNext() != myNode)
			{
				tempNode = tempNode.getNext();
			}
			tempNode = tempNode.getNext();
			Console.WriteLine("Searched Element is: " + tempNode.getKey());

		}

		public void PrintMyNodes()
		{
			StringBuilder myNodes = new StringBuilder("My Nodes: ");
			MyNode tempNode = head;
			while (tempNode.getNext() != null)
			{
				myNodes.Append(tempNode.getKey());
				if (!tempNode.Equals(tail)) myNodes.Append("->");
				tempNode = tempNode.getNext();

			}
			myNodes.Append(tempNode.getKey());
			Console.WriteLine(myNodes);
		}
	}
}
