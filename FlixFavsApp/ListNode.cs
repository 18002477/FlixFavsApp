using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixFavsApp
{
    public class ListNode<T>
    {
        private ListNode<T> next;
        private T item;

        // Property to hold pointer to next ListNode -  Self containing object
        public ListNode<T> Next
        {
            get { return next; }
            set { next = value; }
        }

        // Property to hold value into the Node
        public T Item
        {
            get { return item; }
            set { item = value; }
        }

        // Constructor with item init
        public ListNode(T item)
            : this(item, null)
        {
        }

        // Constructor with item and the next node specified
        public ListNode(T item, ListNode<T> next)
        {
            this.item = item;
            this.next = next;
        }

        // Overriding ToString to return a string value for the item in the node
        public override string ToString()
        {
            if (item == null)
                return string.Empty;
            return item.ToString();
        }
    }
}
