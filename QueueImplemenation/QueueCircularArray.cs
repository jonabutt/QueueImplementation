using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplemenation
{
    public class QueueCircularArray<T>
    {

        private T[] myItems;
        private int front = -1;
        private int rear = -1;

        public QueueCircularArray()
            : this(5)
        {

        }

        public QueueCircularArray(int size)
        {
            myItems = new T[size];
        }

        //check if the array is empty by checking the front is -1, can also be done by checking the rear to -1
        public bool isEmpty()
        {
            if (front == -1)
                return true;
            else
                return false;
        }

        public void Enqueue(T item)
        {
            //check the queue is full by 
            //this is done by checking the next index using the modulo to get the next index
            //this index will be checked against the front index
            if ((rear + 1) % myItems.Length == front)
                throw new InvalidOperationException("Cannot be equeued because queue is full.");
            //check if the array is empty then chaning the index to front and rear to 0
            else if (isEmpty())
            {
                front = rear = 0;
                myItems[rear] = item;
            }
            //this will add a new item by getting a new index using modulo
            //if the "rear+1" == "array length" the result will be zero so it will start over
            else
            {
                rear = (rear+1)%myItems.Length;
                myItems[rear] = item;
            }
        }

        public T Dequeue()
        {
            if (isEmpty())
                throw new InvalidOperationException("Cannot be equeued because queue is full.");
            //this if statement means there is only one item left in the queue,
            //the rear and front will be changed to -1 to describe the array as empty
            else if (front == rear)
            {
                int itemIndex = front;
                front = rear = -1;
                return myItems[itemIndex];
            }
            //this will remove the oldest item and increment the index with modulo forumula
            //if the "front+1" == "array length" the result will be zero so it will start over
            else
            {
                int itemIndex = front;
                front = (front+1)%myItems.Length;
                return myItems[itemIndex];
            }
        }


        //this function checks the rear + 1 with the lenght of the array
        private bool isFull()
        {
            if (rear + 1 == myItems.Length)
                return true;
            else
                return false;
        }
    }
}
