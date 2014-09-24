using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplemenation
{
    public class QueueLinkedList<T>
    {
        //the head node represent the start of the linked list
        public QueueLinkedListNode<T> headNode;
        //the tail node is important in queue becuase when you perform a dequeue function the time will be O(1) with this variable
        public QueueLinkedListNode<T> tailNode;

        //this method will be used to enqueue a node at the rear of linked list
        public void Enqueue(T item)
        {
            //this temporary variable will be used to create a new node  
            QueueLinkedListNode<T> tempNode = new QueueLinkedListNode<T>();
            tempNode.data = item;
            tempNode.next = null;
            //this if function is true when the linked list is empty
            if (headNode == null)
            {
                //the headnode and tailnode will be the same becuase this is the first item of linked list
                headNode = tailNode = tempNode;
                return;
            }
            //if the linked list is not empty, the last node will become second last node and the new node will become last
            tailNode.next = tempNode;
            tailNode = tempNode;
        }

        //this method will be used to return the data of the first node and dequeu the node
        public T Dequeue()
        {
            //this if stament is true when the linked list is empty      
            if (headNode == null)
                throw new InvalidOperationException("Cannot dequeue queue because it's empty.");
            //this temporary node will be used to return the data and changed the first node
            QueueLinkedListNode<T> tempNode = headNode;
            //this if statment is true when there is only one item in the node
            if (headNode == tailNode)
            {
                //the head node and tail node will become empty becuase the dequeue is performed on the last node
                headNode = tailNode = null;
            }
            //this else statement is true when there are multiple nodes in linked list
            else
            {
                //the second node will now become the head node
                headNode = headNode.next;               
            }
            //this will return the data that was in the head nod
            return tempNode.data;
        }

    }

    //this class will be used with the QueueLinkedList to represent a node in a linked list
    public class QueueLinkedListNode<T>
    {
        public T data;
        public QueueLinkedListNode<T> next;
    }
}
