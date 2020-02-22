using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class DoublyLinkedList
    {
        private ListNode head;
        private ListNode tail;
        public int Count { get; private set; }
        public void AddFirst(int element)
        {
            if(this.Count==0)
            {
                this.head = this.tail = new ListNode(element);
            }
            else
            {
                ListNode newHead = new ListNode(element);
                ListNode oldHead = this.head;

                this.head = newHead;
                oldHead.PreviousNode = newHead;
                newHead.NextNode = oldHead;                                                        
            }
            this.Count++;
        }
        public void AddLast(int element)
        {
            if(this.Count==0)
            {
                this.head = this.tail = new ListNode(element);
            }
            else
            {
                ListNode newTail = new ListNode(element);
                ListNode oldTail = this.tail;
                this.tail = newTail;
                oldTail.NextNode = newTail;
                newTail.PreviousNode=oldTail;
            }
        }
    }                                                                                                       
}
