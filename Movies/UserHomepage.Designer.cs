namespace Movies
{
    partial class UserHomepage
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxAction = new System.Windows.Forms.CheckBox();
            this.checkBoxAdventure = new System.Windows.Forms.CheckBox();
            this.checkBoxAnimation = new System.Windows.Forms.CheckBox();
            this.checkBoxBiography = new System.Windows.Forms.CheckBox();
            this.checkBoxComedy = new System.Windows.Forms.CheckBox();
            this.checkBoxCrime = new System.Windows.Forms.CheckBox();
            this.checkBoxDocumentary = new System.Windows.Forms.CheckBox();
            this.checkBoxDrama = new System.Windows.Forms.CheckBox();
            this.checkBoxFantasy = new System.Windows.Forms.CheckBox();
            this.checkBoxHorror = new System.Windows.Forms.CheckBox();
            this.checkBoxMusical = new System.Windows.Forms.CheckBox();
            this.checkBoxRomance = new System.Windows.Forms.CheckBox();
            this.checkBoxScifi = new System.Windows.Forms.CheckBox();
            this.checkBoxSport = new System.Windows.Forms.CheckBox();
            this.checkBoxThriller = new System.Windows.Forms.CheckBox();
            this.checkBoxWar = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.AllowDrop = true;
            this.searchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchBox.Location = new System.Drawing.Point(14, 77);
            this.searchBox.MaxLength = 30;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(367, 20);
            this.searchBox.TabIndex = 0;
            this.searchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Preferences";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBoxAction
            // 
            this.checkBoxAction.AutoSize = true;
            this.checkBoxAction.Location = new System.Drawing.Point(6, 38);
            this.checkBoxAction.Name = "checkBoxAction";
            this.checkBoxAction.Size = new System.Drawing.Size(56, 17);
            this.checkBoxAction.TabIndex = 4;
            this.checkBoxAction.Text = "Action";
            this.checkBoxAction.UseVisualStyleBackColor = true;
            this.checkBoxAction.CheckedChanged += new System.EventHandler(this.checkBoxAction_CheckedChanged);
            // 
            // checkBoxAdventure
            // 
            this.checkBoxAdventure.AutoSize = true;
            this.checkBoxAdventure.Location = new System.Drawing.Point(91, 38);
            this.checkBoxAdventure.Name = "checkBoxAdventure";
            this.checkBoxAdventure.Size = new System.Drawing.Size(75, 17);
            this.checkBoxAdventure.TabIndex = 5;
            this.checkBoxAdventure.Text = "Adventure";
            this.checkBoxAdventure.UseVisualStyleBackColor = true;
            this.checkBoxAdventure.CheckedChanged += new System.EventHandler(this.checkBoxAdventure_CheckedChanged);
            // 
            // checkBoxAnimation
            // 
            this.checkBoxAnimation.AutoSize = true;
            this.checkBoxAnimation.Location = new System.Drawing.Point(196, 38);
            this.checkBoxAnimation.Name = "checkBoxAnimation";
            this.checkBoxAnimation.Size = new System.Drawing.Size(72, 17);
            this.checkBoxAnimation.TabIndex = 6;
            this.checkBoxAnimation.Text = "Animation";
            this.checkBoxAnimation.UseVisualStyleBackColor = true;
            this.checkBoxAnimation.CheckedChanged += new System.EventHandler(this.checkBoxAnimation_CheckedChanged);
            // 
            // checkBoxBiography
            // 
            this.checkBoxBiography.AutoSize = true;
            this.checkBoxBiography.Location = new System.Drawing.Point(284, 38);
            this.checkBoxBiography.Name = "checkBoxBiography";
            this.checkBoxBiography.Size = new System.Drawing.Size(73, 17);
            this.checkBoxBiography.TabIndex = 7;
            this.checkBoxBiography.Text = "Biography";
            this.checkBoxBiography.UseVisualStyleBackColor = true;
            this.checkBoxBiography.CheckedChanged += new System.EventHandler(this.checkBoxBiography_CheckedChanged);
            // 
            // checkBoxComedy
            // 
            this.checkBoxComedy.AutoSize = true;
            this.checkBoxComedy.Location = new System.Drawing.Point(374, 38);
            this.checkBoxComedy.Name = "checkBoxComedy";
            this.checkBoxComedy.Size = new System.Drawing.Size(64, 17);
            this.checkBoxComedy.TabIndex = 8;
            this.checkBoxComedy.Text = "Comedy";
            this.checkBoxComedy.UseVisualStyleBackColor = true;
            this.checkBoxComedy.CheckedChanged += new System.EventHandler(this.checkBoxComedy_CheckedChanged);
            // 
            // checkBoxCrime
            // 
            this.checkBoxCrime.AutoSize = true;
            this.checkBoxCrime.Location = new System.Drawing.Point(6, 61);
            this.checkBoxCrime.Name = "checkBoxCrime";
            this.checkBoxCrime.Size = new System.Drawing.Size(52, 17);
            this.checkBoxCrime.TabIndex = 9;
            this.checkBoxCrime.Text = "Crime";
            this.checkBoxCrime.UseVisualStyleBackColor = true;
            this.checkBoxCrime.CheckedChanged += new System.EventHandler(this.checkBoxCrime_CheckedChanged);
            // 
            // checkBoxDocumentary
            // 
            this.checkBoxDocumentary.AutoSize = true;
            this.checkBoxDocumentary.Location = new System.Drawing.Point(91, 61);
            this.checkBoxDocumentary.Name = "checkBoxDocumentary";
            this.checkBoxDocumentary.Size = new System.Drawing.Size(89, 17);
            this.checkBoxDocumentary.TabIndex = 10;
            this.checkBoxDocumentary.Text = "Documentary";
            this.checkBoxDocumentary.UseVisualStyleBackColor = true;
            this.checkBoxDocumentary.CheckedChanged += new System.EventHandler(this.checkBoxDocumentary_CheckedChanged);
            // 
            // checkBoxDrama
            // 
            this.checkBoxDrama.AutoSize = true;
            this.checkBoxDrama.Location = new System.Drawing.Point(196, 61);
            this.checkBoxDrama.Name = "checkBoxDrama";
            this.checkBoxDrama.Size = new System.Drawing.Size(57, 17);
            this.checkBoxDrama.TabIndex = 11;
            this.checkBoxDrama.Text = "Drama";
            this.checkBoxDrama.UseVisualStyleBackColor = true;
            this.checkBoxDrama.CheckedChanged += new System.EventHandler(this.checkBoxDrama_CheckedChanged);
            // 
            // checkBoxFantasy
            // 
            this.checkBoxFantasy.AutoSize = true;
            this.checkBoxFantasy.Location = new System.Drawing.Point(601, 38);
            this.checkBoxFantasy.Name = "checkBoxFantasy";
            this.checkBoxFantasy.Size = new System.Drawing.Size(63, 17);
            this.checkBoxFantasy.TabIndex = 12;
            this.checkBoxFantasy.Text = "Fantasy";
            this.checkBoxFantasy.UseVisualStyleBackColor = true;
            this.checkBoxFantasy.CheckedChanged += new System.EventHandler(this.checkBoxFantasy_CheckedChanged);
            // 
            // checkBoxHorror
            // 
            this.checkBoxHorror.AutoSize = true;
            this.checkBoxHorror.Location = new System.Drawing.Point(446, 38);
            this.checkBoxHorror.Name = "checkBoxHorror";
            this.checkBoxHorror.Size = new System.Drawing.Size(55, 17);
            this.checkBoxHorror.TabIndex = 13;
            this.checkBoxHorror.Text = "Horror";
            this.checkBoxHorror.UseVisualStyleBackColor = true;
            this.checkBoxHorror.CheckedChanged += new System.EventHandler(this.checkBoxHorror_CheckedChanged);
            // 
            // checkBoxMusical
            // 
            this.checkBoxMusical.AutoSize = true;
            this.checkBoxMusical.Location = new System.Drawing.Point(524, 61);
            this.checkBoxMusical.Name = "checkBoxMusical";
            this.checkBoxMusical.Size = new System.Drawing.Size(62, 17);
            this.checkBoxMusical.TabIndex = 14;
            this.checkBoxMusical.Text = "Musical";
            this.checkBoxMusical.UseVisualStyleBackColor = true;
            this.checkBoxMusical.CheckedChanged += new System.EventHandler(this.checkBoxMusical_CheckedChanged);
            // 
            // checkBoxRomance
            // 
            this.checkBoxRomance.AutoSize = true;
            this.checkBoxRomance.Location = new System.Drawing.Point(446, 61);
            this.checkBoxRomance.Name = "checkBoxRomance";
            this.checkBoxRomance.Size = new System.Drawing.Size(72, 17);
            this.checkBoxRomance.TabIndex = 15;
            this.checkBoxRomance.Text = "Romance";
            this.checkBoxRomance.UseVisualStyleBackColor = true;
            this.checkBoxRomance.CheckedChanged += new System.EventHandler(this.checkBoxRomance_CheckedChanged);
            // 
            // checkBoxScifi
            // 
            this.checkBoxScifi.AutoSize = true;
            this.checkBoxScifi.Location = new System.Drawing.Point(374, 61);
            this.checkBoxScifi.Name = "checkBoxScifi";
            this.checkBoxScifi.Size = new System.Drawing.Size(52, 17);
            this.checkBoxScifi.TabIndex = 16;
            this.checkBoxScifi.Text = "Sci-Fi";
            this.checkBoxScifi.UseVisualStyleBackColor = true;
            this.checkBoxScifi.CheckedChanged += new System.EventHandler(this.checkBoxScifi_CheckedChanged);
            // 
            // checkBoxSport
            // 
            this.checkBoxSport.AutoSize = true;
            this.checkBoxSport.Location = new System.Drawing.Point(284, 61);
            this.checkBoxSport.Name = "checkBoxSport";
            this.checkBoxSport.Size = new System.Drawing.Size(51, 17);
            this.checkBoxSport.TabIndex = 17;
            this.checkBoxSport.Text = "Sport";
            this.checkBoxSport.UseVisualStyleBackColor = true;
            this.checkBoxSport.CheckedChanged += new System.EventHandler(this.checkBoxSport_CheckedChanged);
            // 
            // checkBoxThriller
            // 
            this.checkBoxThriller.AutoSize = true;
            this.checkBoxThriller.Location = new System.Drawing.Point(524, 38);
            this.checkBoxThriller.Name = "checkBoxThriller";
            this.checkBoxThriller.Size = new System.Drawing.Size(57, 17);
            this.checkBoxThriller.TabIndex = 18;
            this.checkBoxThriller.Text = "Thriller";
            this.checkBoxThriller.UseVisualStyleBackColor = true;
            this.checkBoxThriller.CheckedChanged += new System.EventHandler(this.checkBoxThriller_CheckedChanged);
            // 
            // checkBoxWar
            // 
            this.checkBoxWar.AutoSize = true;
            this.checkBoxWar.Location = new System.Drawing.Point(601, 61);
            this.checkBoxWar.Name = "checkBoxWar";
            this.checkBoxWar.Size = new System.Drawing.Size(46, 17);
            this.checkBoxWar.TabIndex = 19;
            this.checkBoxWar.Text = "War";
            this.checkBoxWar.UseVisualStyleBackColor = true;
            this.checkBoxWar.CheckedChanged += new System.EventHandler(this.checkBoxWar_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Popular Movies";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Your Reviews and Ratings";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Recommended for you";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(642, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "sign out";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(660, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Logged in.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxWar);
            this.panel1.Controls.Add(this.checkBoxThriller);
            this.panel1.Controls.Add(this.checkBoxSport);
            this.panel1.Controls.Add(this.checkBoxScifi);
            this.panel1.Controls.Add(this.checkBoxRomance);
            this.panel1.Controls.Add(this.checkBoxMusical);
            this.panel1.Controls.Add(this.checkBoxHorror);
            this.panel1.Controls.Add(this.checkBoxFantasy);
            this.panel1.Controls.Add(this.checkBoxDrama);
            this.panel1.Controls.Add(this.checkBoxDocumentary);
            this.panel1.Controls.Add(this.checkBoxCrime);
            this.panel1.Controls.Add(this.checkBoxComedy);
            this.panel1.Controls.Add(this.checkBoxBiography);
            this.panel1.Controls.Add(this.checkBoxAnimation);
            this.panel1.Controls.Add(this.checkBoxAdventure);
            this.panel1.Controls.Add(this.checkBoxAction);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 90);
            this.panel1.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Search for a movie";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(12, 425);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 105);
            this.panel2.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(495, 230);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(222, 300);
            this.panel3.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(12, 230);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(458, 155);
            this.panel4.TabIndex = 29;
            // 
            // UserHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 542);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchBox);
            this.Name = "UserHomepage";
            this.Text = "Cinema Time!";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxAction;
        private System.Windows.Forms.CheckBox checkBoxAdventure;
        private System.Windows.Forms.CheckBox checkBoxAnimation;
        private System.Windows.Forms.CheckBox checkBoxBiography;
        private System.Windows.Forms.CheckBox checkBoxComedy;
        private System.Windows.Forms.CheckBox checkBoxCrime;
        private System.Windows.Forms.CheckBox checkBoxDocumentary;
        private System.Windows.Forms.CheckBox checkBoxDrama;
        private System.Windows.Forms.CheckBox checkBoxFantasy;
        private System.Windows.Forms.CheckBox checkBoxHorror;
        private System.Windows.Forms.CheckBox checkBoxMusical;
        private System.Windows.Forms.CheckBox checkBoxRomance;
        private System.Windows.Forms.CheckBox checkBoxScifi;
        private System.Windows.Forms.CheckBox checkBoxSport;
        private System.Windows.Forms.CheckBox checkBoxThriller;
        private System.Windows.Forms.CheckBox checkBoxWar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;

    }
}

