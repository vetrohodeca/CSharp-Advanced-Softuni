using System;
namespace LinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            DoublyLinkedList doublyLingedList = new DoublyLinkedList();
            for(int i=0;i<3;i++)
            {
                doublyLingedList.AddFirst(2);
            }
        }
    }
}

