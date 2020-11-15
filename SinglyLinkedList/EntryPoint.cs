using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            SinglyLinkedList sli = new SinglyLinkedList();
            sli.InsertFirst(1);
            sli.InsertFirst(2);
            sli.InsertFirst(3);
            sli.InsertFirst(4);
            sli.InsertFirst(5);
            sli.InsertAfternode(GetNodeByData(sli, 5), 20);
            sli.InsertLast(6);
            sli.DeleteFirst();
            sli.DeleteNodeBykey(sli, 6);
            sli.DeleteLast();

            sli.DisplayList();
            sli.ReverseSinglyLinkedList(sli);
            sli.DisplayList();


        }

        private static Node GetNodeByData(SinglyLinkedList sli, int v)
        {
            Node currentNode = sli.First;
            if(sli.IsEmpty())
            {
                Console.WriteLine("The list is null");
                return null;
            }
            while(currentNode.next != null)
            {
                if (currentNode.data == v)
                    return currentNode;
                currentNode = currentNode.next; 
            }
            return currentNode;

        }
    }
}
