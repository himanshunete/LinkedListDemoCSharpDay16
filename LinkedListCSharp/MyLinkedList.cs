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

		/// <summary>
		/// UC-9 Delete New Inserted Element
		/// </summary>
		/// <param name="deleteNode"></param>
		public void Delete(MyNode deleteNode)
		{
			MyNode tempNode1 = head;
			while (tempNode1.getNext() != deleteNode)
			{
				tempNode1 = tempNode1.getNext();
			}
			MyNode tempNode2 = tempNode1;
			tempNode1 = tempNode1.getNext();
			tempNode1 = tempNode1.getNext();
			tempNode2.setNext(tempNode1);
		}


		public void Size(MyNode head)
		{
			int count = 0;
			MyNode node = head;
			while (node != null)
			{
				count++;
				node = node.getNext();
			}
			Console.WriteLine("Size of LinkedList is: " + count);
		}

		public void Sort()
		{
			MyNode tempNode = this.head;
//			MyNode index = null;
//			int temp;
//			int current = tempNode.getKey();
//			if (this.head == null)
//			{
//				return;
//			}
//			else
//			{
//				while (tempNode.getNext() != null)
//				{
//					index = tempNode.getNext();
//					int	indexKey = index.getKey();
//
//					while (index != null)
//					{
//						if (current > indexKey)
//						{
//							temp = current;
//							current = indexKey;
//							indexKey = temp;
//						}
//						Console.WriteLine(indexKey);
//						index = index.getNext();
//					}
//					tempNode = tempNode.getNext();
//				}
//			}
//			PrintMyNodes();



//			MyNode tempNode1;
//			MyNode tempNode2;
//			MyNode tempNode3;
			int key;
//			int key1;
//			int key2;
//			int key3;
			int[] keyArray = new int[4];
			MyNode[] node = new MyNode[4];
        	int temp;
			for (int i = 0; i < 4 ; i++)
			{
				key = tempNode.getKey();
				node[i] = tempNode;
				keyArray[i] = key;
				tempNode = tempNode.getNext();
				Console.WriteLine(node[i]);
				Console.WriteLine(keyArray[i]);
			}

			for ( int i=0; i < 4;i++)
            {
				for ( int j=0; j<3;j++)
                {
					if ( keyArray[j] > keyArray[j+1])
                    {
						temp = keyArray[j];
						keyArray[j] = keyArray[j + 1];
						keyArray[j + 1] = temp;
                    }
                }
            }

	//		MyNode firstNode = new MyNode(keyArray[0]);
//			MyNode secondNode = new MyNode(keyArray[1]);
//			MyNode thirdNode = new MyNode(keyArray[2]);
//			MyNode fourthNode = new MyNode(keyArray[3]);
//
//			Append(firstNode);
//			Append(secondNode);
//			Append(thirdNode);
//			Append(fourthNode);
			PrintMyNodes();
//		


			//			key = tempNode.getKey();
			//			tempNode1 = tempNode.getNext();
			//			tempNode2 = tempNode1.getNext();
			//			tempNode3 = tempNode2.getNext();
			//			key2 = tempNode2.getKey();
			//			key1 = tempNode1.getKey();
			//			key3 = tempNode3.getKey();
			//			
			//			MyNode firstNode = new MyNode()
			//
			//			Append(tempNode1);
			//			Append(tempNode2);
			//			Append(tempNode);
			//			Append(tempNode3);
			//			PrintMyNodes();

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
