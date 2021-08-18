
namespace FlixFavsApp
{
    partial class MovieForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblRatings = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.txbRatings = new System.Windows.Forms.TextBox();
            this.txbYear = new System.Windows.Forms.TextBox();
            this.txbGenre = new System.Windows.Forms.TextBox();
            this.txbTitle = new System.Windows.Forms.TextBox();
            this.txbMovieID = new System.Windows.Forms.TextBox();
            this.lstMovies = new System.Windows.Forms.ListBox();
            this.txbDisplayMovie = new System.Windows.Forms.TextBox();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnRemoveMovie = new System.Windows.Forms.Button();
            this.btnCarousel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(348, 23);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(263, 35);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Movie PlayList";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(36, 78);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(93, 16);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Movie Title :";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(36, 120);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(58, 16);
            this.lblGenre.TabIndex = 2;
            this.lblGenre.Text = "Genre :";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(36, 159);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(131, 16);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Year Of Release :";
            // 
            // lblRatings
            // 
            this.lblRatings.AutoSize = true;
            this.lblRatings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatings.Location = new System.Drawing.Point(36, 197);
            this.lblRatings.Name = "lblRatings";
            this.lblRatings.Size = new System.Drawing.Size(69, 16);
            this.lblRatings.TabIndex = 4;
            this.lblRatings.Text = "Ratings :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.txbRatings);
            this.panel1.Controls.Add(this.txbYear);
            this.panel1.Controls.Add(this.txbGenre);
            this.panel1.Controls.Add(this.txbTitle);
            this.panel1.Controls.Add(this.txbMovieID);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.lblRatings);
            this.panel1.Controls.Add(this.lblGenre);
            this.panel1.Controls.Add(this.lblYear);
            this.panel1.Location = new System.Drawing.Point(28, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 285);
            this.panel1.TabIndex = 5;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(36, 35);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(31, 16);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "ID :";
            // 
            // txbRatings
            // 
            this.txbRatings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRatings.Location = new System.Drawing.Point(196, 197);
            this.txbRatings.Name = "txbRatings";
            this.txbRatings.Size = new System.Drawing.Size(190, 22);
            this.txbRatings.TabIndex = 9;
            // 
            // txbYear
            // 
            this.txbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbYear.Location = new System.Drawing.Point(196, 155);
            this.txbYear.Name = "txbYear";
            this.txbYear.Size = new System.Drawing.Size(190, 22);
            this.txbYear.TabIndex = 8;
            // 
            // txbGenre
            // 
            this.txbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGenre.Location = new System.Drawing.Point(196, 117);
            this.txbGenre.Name = "txbGenre";
            this.txbGenre.Size = new System.Drawing.Size(190, 22);
            this.txbGenre.TabIndex = 7;
            // 
            // txbTitle
            // 
            this.txbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTitle.Location = new System.Drawing.Point(196, 78);
            this.txbTitle.Name = "txbTitle";
            this.txbTitle.Size = new System.Drawing.Size(190, 22);
            this.txbTitle.TabIndex = 6;
            // 
            // txbMovieID
            // 
            this.txbMovieID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMovieID.Location = new System.Drawing.Point(196, 35);
            this.txbMovieID.Name = "txbMovieID";
            this.txbMovieID.Size = new System.Drawing.Size(190, 22);
            this.txbMovieID.TabIndex = 5;
            // 
            // lstMovies
            // 
            this.lstMovies.FormattingEnabled = true;
            this.lstMovies.Location = new System.Drawing.Point(514, 115);
            this.lstMovies.Name = "lstMovies";
            this.lstMovies.Size = new System.Drawing.Size(467, 108);
            this.lstMovies.TabIndex = 6;
            this.lstMovies.SelectedIndexChanged += new System.EventHandler(this.lstMovies_SelectedIndexChanged);
            // 
            // txbDisplayMovie
            // 
            this.txbDisplayMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDisplayMovie.Location = new System.Drawing.Point(514, 235);
            this.txbDisplayMovie.Multiline = true;
            this.txbDisplayMovie.Name = "txbDisplayMovie";
            this.txbDisplayMovie.ReadOnly = true;
            this.txbDisplayMovie.Size = new System.Drawing.Size(467, 165);
            this.txbDisplayMovie.TabIndex = 10;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(28, 406);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(214, 40);
            this.btnAddMovie.TabIndex = 11;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnRemoveMovie
            // 
            this.btnRemoveMovie.Enabled = false;
            this.btnRemoveMovie.Location = new System.Drawing.Point(268, 406);
            this.btnRemoveMovie.Name = "btnRemoveMovie";
            this.btnRemoveMovie.Size = new System.Drawing.Size(214, 40);
            this.btnRemoveMovie.TabIndex = 12;
            this.btnRemoveMovie.Text = "Remove Movie";
            this.btnRemoveMovie.UseVisualStyleBackColor = true;
            this.btnRemoveMovie.Click += new System.EventHandler(this.btnRemoveMovie_Click);
            // 
            // btnCarousel
            // 
            this.btnCarousel.Location = new System.Drawing.Point(767, 406);
            this.btnCarousel.Name = "btnCarousel";
            this.btnCarousel.Size = new System.Drawing.Size(214, 40);
            this.btnCarousel.TabIndex = 13;
            this.btnCarousel.Text = "Carousel";
            this.btnCarousel.UseVisualStyleBackColor = true;
            this.btnCarousel.Click += new System.EventHandler(this.btnCarousel_Click);
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 485);
            this.Controls.Add(this.btnCarousel);
            this.Controls.Add(this.btnRemoveMovie);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.txbDisplayMovie);
            this.Controls.Add(this.lstMovies);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHeader);
            this.Name = "MovieForm";
            this.Text = "MovieForm";
            this.Load += new System.EventHandler(this.MovieForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblRatings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbYear;
        private System.Windows.Forms.TextBox txbGenre;
        private System.Windows.Forms.TextBox txbTitle;
        private System.Windows.Forms.TextBox txbMovieID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txbRatings;
        private System.Windows.Forms.ListBox lstMovies;
        private System.Windows.Forms.TextBox txbDisplayMovie;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnRemoveMovie;
        private System.Windows.Forms.Button btnCarousel;
    }
}

