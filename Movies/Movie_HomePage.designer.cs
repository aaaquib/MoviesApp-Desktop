namespace Movies
{
    partial class Movie_HomePage
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
            this.movie_name = new System.Windows.Forms.Label();
            this.genrePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.avg_rating_progress = new System.Windows.Forms.ProgressBar();
            this.avg_rating = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.descriptionTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Actors = new System.Windows.Forms.Label();
            this.actorPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ReviewsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.reviewLabel = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.movie_image = new System.Windows.Forms.PictureBox();
            this.theatrePanel = new System.Windows.Forms.TableLayoutPanel();
            this.nowPlayingAtText = new System.Windows.Forms.Label();
            this.directorPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.recommendCB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.movie_image)).BeginInit();
            this.SuspendLayout();
            // 
            // movie_name
            // 
            this.movie_name.AutoSize = true;
            this.movie_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_name.Location = new System.Drawing.Point(233, 13);
            this.movie_name.Name = "movie_name";
            this.movie_name.Size = new System.Drawing.Size(0, 25);
            this.movie_name.TabIndex = 1;
            this.movie_name.Click += new System.EventHandler(this.movie_name_Click);
            // 
            // genrePanel
            // 
            this.genrePanel.Location = new System.Drawing.Point(238, 42);
            this.genrePanel.Name = "genrePanel";
            this.genrePanel.Size = new System.Drawing.Size(354, 21);
            this.genrePanel.TabIndex = 2;
            // 
            // avg_rating_progress
            // 
            this.avg_rating_progress.Location = new System.Drawing.Point(296, 81);
            this.avg_rating_progress.Maximum = 10;
            this.avg_rating_progress.Name = "avg_rating_progress";
            this.avg_rating_progress.Size = new System.Drawing.Size(100, 23);
            this.avg_rating_progress.TabIndex = 3;
            // 
            // avg_rating
            // 
            this.avg_rating.AutoSize = true;
            this.avg_rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avg_rating.Location = new System.Drawing.Point(240, 81);
            this.avg_rating.Name = "avg_rating";
            this.avg_rating.Size = new System.Drawing.Size(0, 22);
            this.avg_rating.TabIndex = 6;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(595, 487);
            this.shapeContainer1.TabIndex = 7;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 236;
            this.lineShape1.X2 = 582;
            this.lineShape1.Y1 = 121;
            this.lineShape1.Y2 = 121;
            // 
            // descriptionTB
            // 
            this.descriptionTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.descriptionTB.Enabled = false;
            this.descriptionTB.Location = new System.Drawing.Point(238, 137);
            this.descriptionTB.Multiline = true;
            this.descriptionTB.Name = "descriptionTB";
            this.descriptionTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTB.Size = new System.Drawing.Size(345, 42);
            this.descriptionTB.TabIndex = 8;
            this.descriptionTB.TextChanged += new System.EventHandler(this.description_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Director :";
            // 
            // Actors
            // 
            this.Actors.AutoSize = true;
            this.Actors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actors.Location = new System.Drawing.Point(241, 214);
            this.Actors.Name = "Actors";
            this.Actors.Size = new System.Drawing.Size(64, 17);
            this.Actors.TabIndex = 11;
            this.Actors.Text = "Actors :";
            // 
            // actorPanel
            // 
            this.actorPanel.AutoScroll = true;
            this.actorPanel.Location = new System.Drawing.Point(318, 217);
            this.actorPanel.Name = "actorPanel";
            this.actorPanel.Size = new System.Drawing.Size(265, 43);
            this.actorPanel.TabIndex = 12;
            // 
            // ReviewsPanel
            // 
            this.ReviewsPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.ReviewsPanel.ColumnCount = 1;
            this.ReviewsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ReviewsPanel.Location = new System.Drawing.Point(13, 271);
            this.ReviewsPanel.Name = "ReviewsPanel";
            this.ReviewsPanel.RowCount = 1;
            this.ReviewsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ReviewsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.ReviewsPanel.Size = new System.Drawing.Size(576, 116);
            this.ReviewsPanel.TabIndex = 15;
            this.ReviewsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ReviewsPanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your Rating";
            // 
            // reviewLabel
            // 
            this.reviewLabel.AutoSize = true;
            this.reviewLabel.Location = new System.Drawing.Point(462, 106);
            this.reviewLabel.Name = "reviewLabel";
            this.reviewLabel.Size = new System.Drawing.Size(111, 13);
            this.reviewLabel.TabIndex = 16;
            this.reviewLabel.TabStop = true;
            this.reviewLabel.Text = "Write/Update Review";
            this.reviewLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.reviewLabel_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.Enabled = false;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(553, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(30, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // movie_image
            // 
            this.movie_image.InitialImage = null;
            this.movie_image.Location = new System.Drawing.Point(12, 13);
            this.movie_image.Name = "movie_image";
            this.movie_image.Size = new System.Drawing.Size(215, 251);
            this.movie_image.TabIndex = 0;
            this.movie_image.TabStop = false;
            // 
            // theatrePanel
            // 
            this.theatrePanel.AutoScroll = true;
            this.theatrePanel.AutoSize = true;
            this.theatrePanel.ColumnCount = 1;
            this.theatrePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.theatrePanel.Location = new System.Drawing.Point(12, 423);
            this.theatrePanel.Name = "theatrePanel";
            this.theatrePanel.RowCount = 1;
            this.theatrePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.theatrePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.theatrePanel.Size = new System.Drawing.Size(580, 61);
            this.theatrePanel.TabIndex = 18;
            // 
            // nowPlayingAtText
            // 
            this.nowPlayingAtText.AutoSize = true;
            this.nowPlayingAtText.BackColor = System.Drawing.Color.Lavender;
            this.nowPlayingAtText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nowPlayingAtText.Location = new System.Drawing.Point(12, 404);
            this.nowPlayingAtText.Name = "nowPlayingAtText";
            this.nowPlayingAtText.Size = new System.Drawing.Size(93, 13);
            this.nowPlayingAtText.TabIndex = 19;
            this.nowPlayingAtText.Text = "Now Playing At";
            // 
            // directorPanel
            // 
            this.directorPanel.AutoScroll = true;
            this.directorPanel.Location = new System.Drawing.Point(318, 182);
            this.directorPanel.Name = "directorPanel";
            this.directorPanel.Size = new System.Drawing.Size(265, 29);
            this.directorPanel.TabIndex = 20;
            // 
            // recommendCB
            // 
            this.recommendCB.AutoSize = true;
            this.recommendCB.Location = new System.Drawing.Point(513, 0);
            this.recommendCB.Name = "recommendCB";
            this.recommendCB.Size = new System.Drawing.Size(86, 17);
            this.recommendCB.TabIndex = 21;
            this.recommendCB.Text = "Recommend";
            this.recommendCB.UseVisualStyleBackColor = true;
            this.recommendCB.CheckedChanged += new System.EventHandler(this.recommendCB_CheckedChanged);
            // 
            // Movie_HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(595, 487);
            this.Controls.Add(this.recommendCB);
            this.Controls.Add(this.directorPanel);
            this.Controls.Add(this.nowPlayingAtText);
            this.Controls.Add(this.theatrePanel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reviewLabel);
            this.Controls.Add(this.ReviewsPanel);
            this.Controls.Add(this.actorPanel);
            this.Controls.Add(this.Actors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descriptionTB);
            this.Controls.Add(this.avg_rating);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.avg_rating_progress);
            this.Controls.Add(this.genrePanel);
            this.Controls.Add(this.movie_name);
            this.Controls.Add(this.movie_image);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Movie_HomePage";
            this.Text = "Shawshank Redemption";
            ((System.ComponentModel.ISupportInitialize)(this.movie_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox movie_image;
        private System.Windows.Forms.Label movie_name;
        private System.Windows.Forms.FlowLayoutPanel genrePanel;
        private System.Windows.Forms.ProgressBar avg_rating_progress;
        private System.Windows.Forms.Label avg_rating;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox descriptionTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Actors;
        private System.Windows.Forms.FlowLayoutPanel actorPanel;
        private System.Windows.Forms.TableLayoutPanel ReviewsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel reviewLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel theatrePanel;
        private System.Windows.Forms.Label nowPlayingAtText;
        private System.Windows.Forms.FlowLayoutPanel directorPanel;
        private System.Windows.Forms.CheckBox recommendCB;
    }
}

