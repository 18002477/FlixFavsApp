using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlixFavsApp
{
    public partial class CarouselForm : Form
    {
        Node current;
       
        public CarouselForm()
        {
            InitializeComponent();
        }

        private void CarouselForm_Load(object sender, EventArgs e)
        {
            //current = WorkerClass.movieList.getHead();
            current = WorkerClass.dLinkedList.getHead();
            txbDisplayMovie.Text = current.movies.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (current.next != null)
            {
                current = current.next;
                txbDisplayMovie.Text = current.movies.ToString();

            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (current.previous != null)
            {
                current = current.previous;
                txbDisplayMovie.Text = current.movies.ToString();
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int index = random.Next(0, WorkerClass.dLinkedList.length());
            //MessageBox.Show("Index : " + index + "- Movie Data: " + WorkerClass.dLinkedList[index].movies.ToString());
        }
    }
}
