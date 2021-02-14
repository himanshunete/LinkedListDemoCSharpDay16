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
        /// TC-2 Test Linked List
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
            myLinkedList.printMyNodes();
            bool result = myLinkedList.head.Equals(myThirdNode) &&
                             myLinkedList.head.getNext().Equals(mySecondNode) &&
                             myLinkedList.tail.Equals(myFirstNode);
            Assert.True(result);
        }

    }
}