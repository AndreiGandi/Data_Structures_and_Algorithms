using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    public class SinglyLinkedList
    {
        private Node first;

        public Node First { get; set; }

        public bool IsEmpty() // Check if list is null. 
        {
            return (First == null);
        }
        public void DisplayList()
        {
            Console.WriteLine("Singly Linked List: ");
            Node currentNode = First;
            while(currentNode != null)
            {
                currentNode.DisplayNode();
                currentNode = currentNode.next;
            }
            Console.WriteLine();
        }

        public void InsertFirst(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = First;
            First = newNode;
        }
        public void InsertLast(int data)
        {
            Node currentNode = First;
            while(currentNode.next != null)
            {
                currentNode = currentNode.next;
            }
            Node newNode = new Node();
            newNode.data = data;
            currentNode.next = newNode;
        }
        public void InsertAfternode(Node prev_node,int data)
        {
            if(prev_node == null)
            {
                Console.WriteLine("The previous node cannot be null");
                return;
            }
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = prev_node.next;
            prev_node.next = newNode;
        }

        public Node DeleteFirst()
        {
            Node temp = First;
            First = First.next;
            return temp;
        }
        public Node DeleteLast()
        {
            Node temp = First;
            Node previousNode = null;
            while(temp.next!=null)
            {
                previousNode = temp;
                temp = temp.next;
            }
            previousNode.next = temp.next;
            return previousNode;
        }

        public void DeleteNodeBykey(SinglyLinkedList singlyList, int key)
        {
            Node temp = singlyList.First;
            Node previousNode = null;

            if (temp != null && temp.data == key) 
            {
                first = temp.next;
                return;
            }
            while(temp != null && temp.data != key)
            {
                previousNode = temp;
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            previousNode.next = temp.next;
        }

        public void ReverseSinglyLinkedList(SinglyLinkedList sli)
        {
            Node previousNode = null;
            Node nextNode = null;
            Node currentNode = sli.First;
            while(currentNode != null)
            {
                nextNode = currentNode.next;
                currentNode.next = previousNode;
                previousNode = currentNode;
                currentNode = nextNode;
            }
            sli.First = previousNode;
        }
        
    }
}
