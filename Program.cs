using System;

namespace StackAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            linkedListStack.Display();
            Console.WriteLine("-------------------");
            linkedListStack.Peek();
            linkedListStack.Display();
            Console.WriteLine("-------------------");
            linkedListStack.Pop();
            linkedListStack.Display();
            Console.WriteLine("-------------------");
            linkedListStack.isEmpty();
            linkedListStack.Display();


        }
    }
}
