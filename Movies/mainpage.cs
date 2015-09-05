using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace movies_database_homepage
{
    public partial class mainpage : Form
    {
        public DataTable now_playing;
        public String s = "server=localhost;User Id=root;database=moviedb";
        public MySqlConnection conn;
        public MySqlDataAdapter my_data_adapter;
        public DataSet my_dataset;
        public DataTable my_data_table;
        AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
        AutoCompleteStringCollection ac1 = new AutoCompleteStringCollection();
        AutoCompleteStringCollection ac2 = new AutoCompleteStringCollection();
        public mainpage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            conn = new MySqlConnection(s);
            conn.Open();
            switch (comboBox1.SelectedIndex)
            { 
                case 0:
                    String sql1 = "select Title from movie";
                     my_data_adapter = new MySqlDataAdapter(sql1, conn);
                        my_dataset = new DataSet();
                        my_data_table = new DataTable();
                        my_data_adapter.Fill(my_dataset, "movies");
                        my_data_table = my_dataset.Tables["movies"];
                        //MessageBox.Show("count= "+my_data_table.Rows.Count);
                        for (int i = 0; i < my_data_table.Rows.Count; i++)
                        {
                            DataRow dr = my_data_table.Rows[i];
                            ac.Add(dr[0].ToString());
                        }
                        textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
                        textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        textBox1.AutoCompleteCustomSource = ac;
                            break;
                case 1:
                    String sql2 = "selece Fname,Lname from person p,actor a where p.SSN=a.SSN";
                    my_data_adapter = new MySqlDataAdapter(sql2, conn);
                        my_dataset = new DataSet();
                        my_data_table = new DataTable();
                        my_data_adapter.Fill(my_dataset, "actors");
                        my_data_table = my_dataset.Tables["actors"];
                       // MessageBox.Show("count= "+my_data_table.Rows.Count);
                        for (int i = 0; i < my_data_table.Rows.Count; i++)
                        {
                            DataRow dr = my_data_table.Rows[i];
                            ac1.Add(dr[0].ToString()+" "+dr[1].ToString());
                        }
                        textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
                        textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        textBox1.AutoCompleteCustomSource = ac1;
                    break;
                case 2:
                    String sql3 = "selece Fname,Lname from person p,director d where p.SSN=d.SSN";
                    my_data_adapter = new MySqlDataAdapter(sql3, conn);
                        my_dataset = new DataSet();
                        my_data_table = new DataTable();
                        my_data_adapter.Fill(my_dataset, "directors");
                        my_data_table = my_dataset.Tables["directors"];
                       // MessageBox.Show("count= "+my_data_table.Rows.Count);
                        for (int i = 0; i < my_data_table.Rows.Count; i++)
                        {
                            DataRow dr = my_data_table.Rows[i];
                            ac2.Add(dr[0].ToString()+" "+dr[1].ToString());
                        }
                        textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
                        textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        textBox1.AutoCompleteCustomSource = ac2;
                    break;
            }


            String sql = "SELECT distinct m.filmID,m.Title,m.MoviePoster FROM now_playing np,movie m WHERE np.filmID=m.filmID";
            my_data_adapter = new MySqlDataAdapter(sql, conn);
            my_dataset = new DataSet();
            my_data_table = new DataTable();
            my_data_adapter.Fill(my_dataset, "now playing movies");
            my_data_table = my_dataset.Tables["now playing movies"];
            now_playing = my_data_table;
            get_now_playing(0);
            
        }
        public void get_now_playing(int index)
        {
            Boolean flag = false;
            int i=0 ;
            for (i = index % 4; (i < 4); i++)
            {
                if ((index + i < now_playing.Rows.Count) && (index + i >= 0))
                {
                    flag = true;
                    int temp = index + i;
                    //MessageBox.Show("coming inside the loop "+temp);
                    DataRow dr = now_playing.Rows[index + i];
                    byte[] image_bytes = (byte[])dr[2];
                    MemoryStream ms = new MemoryStream(image_bytes);
                    System.Drawing.Bitmap img = new System.Drawing.Bitmap(ms);
                    switch (i)
                    {
                        case 0:
                            pictureBox1.Image = img;
                            pictureBox1.Tag = dr[0];
                            break;
                        case 1:
                            pictureBox2.Image = img;
                            pictureBox2.Tag = dr[0];
                            break;
                        case 2:
                            pictureBox3.Image = img;
                            pictureBox3.Tag = dr[0];
                            break;
                        case 3:
                            pictureBox4.Image = img;
                            pictureBox4.Tag = dr[0];
                            break;
                    }
                }
            }
            if (flag)
            {
                button5.Tag = index + i;
                button4.Tag = index + i;
            }
            if (index + i -8< 0)
            {
                button5.Enabled = false;
            }
            else if (index + i - 8 >= 0)
            {
                button5.Enabled = true;
            
            }
            if(index + i > now_playing.Rows.Count)
            {
                button4.Enabled = false;
            }
            else if( index + i <= now_playing.Rows.Count)
            {
                button4.Enabled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            loginpage f2 = new loginpage("login");
            f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginpage f2 = new loginpage("register");
            f2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            { 
                case 0:
                    //movies
                    movies_search_display f3_movies = new movies_search_display(0,textBox1.Text);
                    //MessageBox.Show("coming here 1");
                    f3_movies.Show();
                    break;
                case 1:
                    //actor
                    movies_search_display f3_actors = new movies_search_display(1, textBox1.Text);
                    //MessageBox.Show("coming here 2");
                    f3_actors.Show();
                    break;
                case 2:
                    //directors
                    movies_search_display f3_directors = new movies_search_display(2, textBox1.Text);
                    //MessageBox.Show("coming here 3");
                    f3_directors.Show();
                    break;
                default:
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //go to movies page
            Movies.Movie_HomePage mh = new Movies.Movie_HomePage(pictureBox1.Tag.ToString(), "0000000");
            mh.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //go to movies page
            Movies.Movie_HomePage mh = new Movies.Movie_HomePage(pictureBox2.Tag.ToString(), "0000000");
            mh.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //go to movies page
            Movies.Movie_HomePage mh = new Movies.Movie_HomePage(pictureBox3.Tag.ToString(), "0000000");
            mh.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Movies.Movie_HomePage mh = new Movies.Movie_HomePage(pictureBox4.Tag.ToString(), "0000000");
            mh.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(s);
                conn.Open();
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        String sql1 = "select Title from movie";
                        my_data_adapter = new MySqlDataAdapter(sql1, conn);
                        my_dataset = new DataSet();
                        my_data_table = new DataTable();
                        my_data_adapter.Fill(my_dataset, "movies");
                        my_data_table = my_dataset.Tables["movies"];
                       // MessageBox.Show("count= " + my_data_table.Rows.Count);
                        for (int i = 0; i < my_data_table.Rows.Count; i++)
                        {
                            DataRow dr = my_data_table.Rows[i];
                            ac.Add(dr[0].ToString());
                        }
                        textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
                        textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        textBox1.AutoCompleteCustomSource = ac;
                        break;
                    case 1:
                        String sql2 = "select Fname,Lname from person p,actor a where p.SSN=a.SSN";
                        my_data_adapter = new MySqlDataAdapter(sql2, conn);
                        my_dataset = new DataSet();
                        my_data_table = new DataTable();
                        my_data_adapter.Fill(my_dataset, "actors");
                        my_data_table = my_dataset.Tables["actors"];
                        // MessageBox.Show("count= "+my_data_table.Rows.Count);
                        for (int i = 0; i < my_data_table.Rows.Count; i++)
                        {
                            DataRow dr = my_data_table.Rows[i];
                            ac1.Add(dr[0].ToString() + " " + dr[1].ToString());
                        }
                        textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
                        textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        textBox1.AutoCompleteCustomSource = ac1;
                        break;
                    case 2:
                        String sql3 = "select Fname,Lname from person p,director d where p.SSN=d.SSN";
                        my_data_adapter = new MySqlDataAdapter(sql3, conn);
                        my_dataset = new DataSet();
                        my_data_table = new DataTable();
                        my_data_adapter.Fill(my_dataset, "directors");
                        my_data_table = my_dataset.Tables["directors"];
                        // MessageBox.Show("count= "+my_data_table.Rows.Count);
                        for (int i = 0; i < my_data_table.Rows.Count; i++)
                        {
                            DataRow dr = my_data_table.Rows[i];
                            ac2.Add(dr[0].ToString() + " " + dr[1].ToString());
                        }
                        textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
                        textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        textBox1.AutoCompleteCustomSource = ac2;
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                get_now_playing((int)button4.Tag);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
               // MessageBox.Show("coming here" + (int)button4.Tag);
                get_now_playing(((int)button4.Tag) - 8);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
