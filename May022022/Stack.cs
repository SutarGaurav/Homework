using System;
using System.Collections.Generic;
using System.Text;

namespace CSHomework.May022022
{
    //Generic stack FILO
    class Stack
    {
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            s.Push(5);
            s.Push(4);
            s.Push(3);
            s.Push(2);
            s.Push(1);
            s.Pop();
            foreach(int a in s)
            {
                Console.WriteLine(a);
            }

        }
        
             
    }
}
