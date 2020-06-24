using System;
using System.Collections.Generic;
using System.Text;

namespace ds_algo.LinkedLists
{
    public static class LinkedListActions
    {
        public static ListNode Initialize()
        {
            ListNode head = new ListNode(1);
            head.Next = new ListNode(2);
            head.Next.Next = new ListNode(3);
            head.Next.Next.Next = new ListNode(4);
            head.Next.Next.Next.Next = new ListNode(5);

            ListNode cNode = head;
            string originalLinkedList = null;
            while (cNode != null)
            {
                originalLinkedList += $"{cNode.Value}, ";
                cNode = cNode.Next;
            }
            Console.WriteLine($"Original linked-list: {originalLinkedList}");

            return head;
        }

        public static void Reverse(this ListNode head)
        {
            ListNode currentNode = head;
            ListNode previousNode = null;
            ListNode tempNext;

            while (currentNode != null)
            {
                tempNext = currentNode.Next;
                currentNode.Next = previousNode;
                previousNode = currentNode;
                currentNode = tempNext;
            }

            ListNode cNode = previousNode;
            string reversedLinkedList = null;
            while (cNode != null)
            {
                reversedLinkedList += $"{cNode.Value}, ";
                cNode = cNode.Next;
            }
            Console.WriteLine($"Reversed linked-list: {reversedLinkedList}");
        }

        public static void Find(this ListNode head, int value)
        {
            ListNode currentNode = head;

            int index = 0;
            while (currentNode != null)
            {
                if (currentNode.Value == value)
                {
                    Console.WriteLine($"Item {value} found at index {index}");
                }
                currentNode = currentNode.Next;
                index++;
            }
        }
    }
}
