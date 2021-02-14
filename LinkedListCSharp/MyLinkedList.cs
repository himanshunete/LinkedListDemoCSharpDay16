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
