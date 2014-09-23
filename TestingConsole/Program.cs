using QueueImplemenation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueCircularArray<int> myQ = new QueueCircularArray<int>();
             myQ.Enqueue(1);
            myQ.Enqueue(23);
            myQ.Enqueue(43);
            myQ.Enqueue(23);
            myQ.Enqueue(2432);
            myQ.Dequeue();
            myQ.Dequeue();
            myQ.Enqueue(2432);
            Console.ReadKey();
        }
    }
}
