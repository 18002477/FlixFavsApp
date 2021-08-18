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
    public partial class MovieForm : Form
    {
        Node current;
        public MovieForm()
        {
            InitializeComponent();
        }

        public void clearFields() 
        {
            txbMovieID.Clear();
            txbTitle.Clear();
            txbGenre.Clear();
            txbYear.Clear();
            txbRatings.Clear();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            try
            {

                int year = Convert.ToInt32(txbYear.Text);
                int rating = Convert.ToInt32(txbRatings.Text);
                Movie movie = new Movie(txbMovieID.Text, txbTitle.Text, txbGenre.Text, year, rating);
                clearFields();

                Node newNode = new Node(movie);
                //WorkerClass.movieList.Append(newNode);
                //WorkerClass.dLinkedList.append(newNode);
                WorkerClass.dLinkedList.insertAfter(movie, 2);
                //WorkerClass.cLinkedList.append(newNode);

                txbDisplayMovie.Clear();

                txbDisplayMovie.Text += "Size :" + WorkerClass.dLinkedList.length() + Environment.NewLine;
                txbDisplayMovie.Text += WorkerClass.dLinkedList.ToString() + Environment.NewLine;
                txbDisplayMovie.Text += "------------------------------------" + Environment.NewLine;

                lstMovies.Items.Add(movie.Title);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnRemoveMovie_Click(object sender, EventArgs e)
        {
           
            string selectedMovie = lstMovies.SelectedItem.ToString();
            if (current.movies.Title.Equals(selectedMovie))
            {
                
            }
        }

        private void MovieForm_Load(object sender, EventArgs e)
        {
           /* Movie movie1 = new Movie("1001", "Black Panther", "Action", 2018, 7);
            Movie movie2 = new Movie("1002", "The Wolf of Wall Street", "Drama/Comedy", 2013, 8);
            Movie movie3 = new Movie("1003", "Without Remorse", "Action", 2021, 6);
            Node newNode1 = new Node(movie1);
            Node newNode2 = new Node(movie2);
            Node newNode3 = new Node(movie3);
            WorkerClass.dLinkedList.append(newNode1);
            WorkerClass.dLinkedList.append(newNode2);
            WorkerClass.dLinkedList.append(newNode3);

            txbDisplayMovie.Text += "Size :" + WorkerClass.dLinkedList.length() + Environment.NewLine;
            txbDisplayMovie.Text += WorkerClass.dLinkedList.ToString() + Environment.NewLine;
            txbDisplayMovie.Text += "------------------------------------" + Environment.NewLine;

            lstMovies.Items.Add(movie1.Title);
            lstMovies.Items.Add(movie2.Title);
            lstMovies.Items.Add(movie3.Title);*/

        }

        private void lstMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* string selectedMovie = lstMovies.SelectedItem.ToString();
            if (current.movies.Title.Equals(selectedMovie))
            {
                txbDisplayMovie.Clear();

                txbDisplayMovie.Text += "Size :" + WorkerClass.movieList.length() + Environment.NewLine;
                txbDisplayMovie.Text += WorkerClass.movieList.ToString() + Environment.NewLine;
                txbDisplayMovie.Text += "------------------------------------" + Environment.NewLine;
            }*/

        }

        private void btnCarousel_Click(object sender, EventArgs e)
        {
            this.Hide();
            CarouselForm carouselForm = new CarouselForm();
            carouselForm.ShowDialog();
            this.Show();
        }


    }
}
