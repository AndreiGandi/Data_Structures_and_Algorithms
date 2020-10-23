using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    public class Node
    {
        public int data; // data stored in node
        public Node next; // reference to next node;
        public void DisplayNode() // Display node methods
        {
            Console.Write("<" + data + "> ");
        }
    }
}
