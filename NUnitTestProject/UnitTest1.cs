using NUnit.Framework;
using LinkedListCSharp;

namespace NUnitTestProject
{

    public class Tests
    {
        MyNode myFirstNode;
        MyNode mySecondNode;
        MyNode myThirdNode;
       
        /// <summary>
        /// TC-1 Test Simple Linked List
        /// </summary>
        [Test]
        public void Given3Elements_WhenSimpleLinkedListIsCreated_ShouldPassTest()
        {
            myFirstNode = new MyNode(56);
            mySecondNode = new MyNode(30);
            myThirdNode = new MyNode(70);
            myFirstNode.setNext(mySecondNode);
            mySecondNode.setNext(myThirdNode);
            bool result = myFirstNode.getNext().Equals(mySecondNode) &&
                             mySecondNode.getNext().Equals(myThirdNode);
            Assert.True(result);
        }


        /// <summary>
        /// TC-2 Test Linked List for Add method
        /// </summary>
        [Test]
        public void Given3Number_WhenAddedToLinkedList_ShouldBeAddedToTop()
        {
            myFirstNode = new MyNode(70);
            mySecondNode = new MyNode(30);
            myThirdNode = new MyNode(56);
            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.Add(myFirstNode);
            myLinkedList.Add(mySecondNode);
            myLinkedList.Add(myThirdNode);
            myLinkedList.PrintMyNodes();
            bool result = myLinkedList.head.Equals(myThirdNode) &&
                             myLinkedList.head.getNext().Equals(mySecondNode) &&
                             myLinkedList.tail.Equals(myFirstNode);
            Assert.True(result);
        }

        /// <summary>
        /// TC-3 Test for Append method
        /// </summary>
        [Test]
        public void Given3Number_WhenAppendedToLinkedList_ShouldBeAppendedToLast()
        {
            MyNode myFirstNode = new MyNode(56);
            MyNode mySecondNode = new MyNode(30);
            MyNode myThirdNode = new MyNode(70);
            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.Append(myFirstNode);
            myLinkedList.Append(mySecondNode);
            myLinkedList.Append(myThirdNode);
            myLinkedList.PrintMyNodes();
            bool result = myLinkedList.head.Equals(myFirstNode) &&
                             myLinkedList.head.getNext().Equals(mySecondNode) &&
                             myLinkedList.tail.Equals(myThirdNode);
            Assert.True(result);
        }
        /// <summary>
        /// TC-4 Test for Insert method
        /// </summary>
        [Test]
        public void Given3Number_WhenInserted_ShouldPassTheLinkedListTest()
        {
            MyNode myFirstNode = new MyNode(56);
            MyNode mySecondNode = new MyNode(30);
            MyNode myThirdNode = new MyNode(70);
            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.Add(myFirstNode);
            myLinkedList.Append(myThirdNode);
            myLinkedList.PrintMyNodes();
            myLinkedList.Insert(mySecondNode, myThirdNode);
            myLinkedList.PrintMyNodes();
            bool result = myLinkedList.head.Equals(myFirstNode) &&
                             myLinkedList.head.getNext().Equals(mySecondNode) &&
                             myLinkedList.tail.Equals(myThirdNode);
            Assert.True(result);
        }

        /// <summary>
        /// TC-5 Test For Pop method
        /// </summary>
        [Test]
        public void Given3Number_WhenDeletedFirstElement_ShouldPassTheLinkedListTest()
        {
            MyNode myFirstNode = new MyNode(56);
            MyNode mySecondNode = new MyNode(30);
            MyNode myThirdNode = new MyNode(70);
            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.Append(myFirstNode);
            myLinkedList.Append(mySecondNode);
            myLinkedList.Append(myThirdNode);
            myLinkedList.Pop();
            myLinkedList.PrintMyNodes();
            bool result = myLinkedList.head.Equals(mySecondNode) &&
                             myLinkedList.tail.Equals(myThirdNode);
            Assert.True(result);
        }

        /// <summary>
        /// TC-6 Test For PopLast method
        /// </summary>
        [Test]
        public void Given3Number_WhenDeletedLastElement_ShouldPassTheLinkedListTest()
        {
            MyNode myFirstNode = new MyNode(56);
            MyNode mySecondNode = new MyNode(30);
            MyNode myThirdNode = new MyNode(70);
            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.Add(myFirstNode);
            myLinkedList.Add(mySecondNode);
            myLinkedList.Add(myThirdNode);
            myLinkedList.PopLast();
            myLinkedList.PrintMyNodes();
            bool result = myLinkedList.head.Equals(myFirstNode) &&
                             myLinkedList.tail.Equals(mySecondNode);
            Assert.True(result);
        }




    }
}