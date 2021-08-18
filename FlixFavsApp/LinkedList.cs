using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixFavsApp
{
    public class LinkedList
    {
        // Declaration of member variables and Size
        private Node head;// Reference of the first node of the link list
        //private Node tail; // Reference of the last node of the link list
        private int size; // Number of nodes in the link list

        public LinkedList()
        {
            head = null;
            //tail = null;
            size = 0;
        }

        // Checking the length of the List
        public int length()
        {
            return size;
        }

        public bool isEmpty()
        {
            return head == null;
        }

        public Node getHead()
        {
            return head;
        }

        //Adding last element to the list
        public void Append(Node node)
        {
            if (isEmpty())
            {
                head = node; // If the node is empty the coming element becomes the head.
            }
            else
            {
                // Add a second element to the node.
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = node;
            }
            size++;
        }

        // Removing element from the node
        public void remove(string name)
        {
            Node current;
            if (isEmpty())
            {
                // Empty
                current = head;
            }
            else
            {
                current = head;
                if (current.movies.Equals(name))
                {
                    head = current.next;
                    size--;
                }

                Node previous = null;
                while (current.next != null)
                {
                    if (current.movies.Title.Equals(name))
                    {
                        previous = current;
                        current = current.next;
                    }
                    else
                    {
                        previous.next = current.next;
                        size--;
                    }
                }

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
