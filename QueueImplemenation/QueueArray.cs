using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplemenation
{
    public class QueueArray<T>
    {
        private T[] myItems;
        private int front = -1;
        private int rear = -1;

        public QueueArray()
            : this(5)
        {

        }

        public QueueArray(int size)
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
            //check the queue is full
            if (isFull())
                throw new InvalidOperationException("Cannot be equeued because queue is full.");

            //check if the array is empty then chaning the index to front and rear to 0
            else if (isEmpty())
            {
                front = rear = 0;
                myItems[rear] = item;
            }
            //adding an item normally by adding one to rear index and add the item
            else
            {
                rear++;
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
            //this block increment the front index and the return the item
            else
            {
                int itemIndex = front;
                front++;
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
