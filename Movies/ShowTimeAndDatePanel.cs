using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Movies
{
    public partial class ShowTimeAndDatePanel : Form
    {
        public ShowTimeAndDatePanel()
        {
            InitializeComponent();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void date_time_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
