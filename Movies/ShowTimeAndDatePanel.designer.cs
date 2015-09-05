namespace Movies
{
    partial class ShowTimeAndDatePanel
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
            this.date_time_panel = new System.Windows.Forms.TableLayoutPanel();
            this.ok_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // date_time_panel
            // 
            this.date_time_panel.AutoScroll = true;
            this.date_time_panel.AutoSize = true;
            this.date_time_panel.ColumnCount = 1;
            this.date_time_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.date_time_panel.Location = new System.Drawing.Point(1, 2);
            this.date_time_panel.Name = "date_time_panel";
            this.date_time_panel.RowCount = 1;
            this.date_time_panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.date_time_panel.Size = new System.Drawing.Size(489, 111);
            this.date_time_panel.TabIndex = 0;
            this.date_time_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.date_time_panel_Paint);
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(201, 119);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(75, 23);
            this.ok_btn.TabIndex = 1;
            this.ok_btn.Text = "Ok";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // ShowTimeAndDatePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 154);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.date_time_panel);
            this.Name = "ShowTimeAndDatePanel";
            this.Text = "Movie Schedule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel date_time_panel;
        private System.Windows.Forms.Button ok_btn;
    }
}