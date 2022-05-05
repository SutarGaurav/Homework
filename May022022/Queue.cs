using System;
using System.Collections.Generic;
using System.Text;

namespace CSHomework.May022022
{
    //Generic Queue FIFO
    class Queue
    {
        static void Main(string[] args)
        {
            Queue<char> q = new Queue<char>();
            q.Enqueue('A');
            q.Enqueue('B');
            q.Enqueue('C');
            q.Enqueue('D');
            q.Enqueue('E');
            q.Dequeue();
            foreach(char a in q)
            {
                Console.WriteLine(a);
            }
        }
    }
}
