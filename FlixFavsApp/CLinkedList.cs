using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixFavsApp
{
    public class CLinkedList
    {
        Node head;
        Node current;
        int size = 0;

        public Node getHead()
        {
            return head;
        }

        public int length()
        {
            return size;
        }
        public bool isEmpty()
        {
            return head == null;
        }

        public void append(Node node)
        {
            // Checking if we have a head
            if (isEmpty())
            {
                head = node; // If we dont have one we create a head
                head.next = head;
                size++;
                return; // Exit the code block
            }
            else
            {
                // if head is not null Current becomes the head
                current = head;
                // Traversing through the list to get bck to the head
                while (current.next != head)
                {
                    // Moving through the list one node at the time
                    current = current.next;
                }
                // Creating a new node new node if current.next is empty
                current.next = node;
                node.next = head;
                size++;
            }
        }

        public override string ToString()
        {
            string output = "";
            Node current = head;
            while (current != null)
            {
                output += current.movies.ToString() + Environment.NewLine;
                current = current.next;
            }
            return output;
        }
    }
}
