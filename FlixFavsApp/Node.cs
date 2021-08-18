using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixFavsApp
{
    // Defining the Node Class
    public class Node
    {
        public Movie movies;
        public Node next;
        public Node previous;

        public Node(Movie m) 
        {
            this.movies = m;
           /* this.next = null;
            this.previous = null;*/
        }
        public Node(Movie m, Node n)
        {
            this.movies = m;
            this.next = n;
            this.previous = null;
        }
    }
}
