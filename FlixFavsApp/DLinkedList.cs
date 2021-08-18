using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixFavsApp
{
    public class DLinkedList
    {
        Node head;
        Node current;
        Node tail;
        Node temp;
        int size = 0;
        /*List<string> nextList;
        List<string> prevList;*/

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
                head.next = null;
                head.previous = null;
                size++;
                return;
            }
            else
            {
                // if head is not null Current becomes the head
                current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = node;
                node.previous = current;
                tail = node;
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

        // Inserting after a particular node data + node count
        public void insertAfter(Movie m, int after) 
        {
            Node customNode = new Node(m);
            current = head;
            int ithNode = 1;
            while (ithNode != after)
            {
                current = current.next;
                ithNode++;
            }
            // temp node to contain the data of the next node after the insert position
            temp = current.next;
            // inserting a new node after the count for int
            current.next = customNode;
            customNode.next = temp;
            temp.previous = customNode;
            customNode.previous = current;

        }

    }
}
