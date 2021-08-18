
namespace FlixFavsApp
{
    partial class CarouselForm
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
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.txbDisplayMovie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(54, 169);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(146, 40);
            this.btnPrevious.TabIndex = 12;
            this.btnPrevious.Text = " << Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(574, 169);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(146, 40);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "Next >>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(262, 329);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(266, 40);
            this.btnRandom.TabIndex = 14;
            this.btnRandom.Text = "Feeling Lucky ?";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // txbDisplayMovie
            // 
            this.txbDisplayMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDisplayMovie.Location = new System.Drawing.Point(262, 61);
            this.txbDisplayMovie.Multiline = true;
            this.txbDisplayMovie.Name = "txbDisplayMovie";
            this.txbDisplayMovie.ReadOnly = true;
            this.txbDisplayMovie.Size = new System.Drawing.Size(266, 262);
            this.txbDisplayMovie.TabIndex = 15;
            // 
            // CarouselForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbDisplayMovie);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Name = "CarouselForm";
            this.Text = "CarouselForm";
            this.Load += new System.EventHandler(this.CarouselForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.TextBox txbDisplayMovie;
    }
}