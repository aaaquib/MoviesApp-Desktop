using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;
using System.Drawing;
namespace Movies
{
    public partial class Movie_HomePage : Form
    {
        public String s = "server=localhost;User Id=root;database=moviedb";
        public MySqlDataAdapter my_data_adapter;
        MySqlConnection conn;
        public DataSet my_dataset;
        public DataTable my_data_table;
        public MySqlDataReader mrdr;
        String filmId = "";//will be dynamic
        String loggedInUserSSN = ""; //will be dynamic
        bool screenLoaded = false;
        public Movie_HomePage(String filmUID, String UserSSN)
        {
            
            filmId = filmUID;
            loggedInUserSSN = UserSSN;
            InitializeComponent();
            screenLoaded = false;
            PopulateMovieHomepage(filmId, loggedInUserSSN);
            screenLoaded = true;
        }

        private void movie_name_Click(object sender, EventArgs e)
        {

        }

        public void PopulateMovieHomepage(String FilmId, String SSN)
        {
            //Fetch details of the movie from the database

            try
            {

                conn = new MySqlConnection(s);
                conn.Open();
                String SQL = "Select * from movie where filmID = " + FilmId;
                my_data_adapter = new MySqlDataAdapter(SQL, conn);
                my_dataset = new DataSet();
                my_data_table = new DataTable();

                my_data_adapter.Fill(my_dataset, "movie");
                my_data_table = my_dataset.Tables["movie"];

                DataRow dr = my_data_table.Rows[0];

                String title = dr.ItemArray[1].ToString();
                String year = dr.ItemArray[2].ToString();
                String rating = dr.ItemArray[3].ToString();
                String description = dr.ItemArray[4].ToString();

                byte[] barrImg = (byte[])dr.ItemArray[5];
                MemoryStream mstream = new MemoryStream(barrImg);
                movie_image.Image = Image.FromStream(mstream);
                movie_name.Text = title;

                // avg_rating.Text = rating;
                //avg_rating_progress.Value = (int)float.Parse(rating);

                descriptionTB.Text = description;

                this.Text = title + " - " + year;

                SQL = "SELECT fname,lname FROM `person` WHERE SSN IN (Select SSN from director where filmid = " + FilmId + ")";
                my_data_adapter = new MySqlDataAdapter(SQL, conn);
                my_dataset = new DataSet();
                my_data_table = new DataTable();

                my_data_adapter.Fill(my_dataset, "movie");
                my_data_table = my_dataset.Tables["movie"];


                for (int i = 0; i < my_data_table.Rows.Count; i++)
                {
                    dr = my_data_table.Rows[i];
                    String fname = dr.ItemArray[0].ToString();
                    String lname = dr.ItemArray[1].ToString();
                    String director = fname + " " + lname;
                    Label directorLabel = new Label();
                    directorLabel.Text = director;
                    directorLabel.AutoSize = true;
                    directorPanel.Controls.Add(directorLabel);


                }

                directorPanel.BorderStyle = BorderStyle.FixedSingle;

                SQL = "SELECT distinct genre FROM `genre` WHERE filmid = " + FilmId;
                my_data_adapter = new MySqlDataAdapter(SQL, conn);
                my_dataset = new DataSet();
                my_data_table = new DataTable();

                my_data_adapter.Fill(my_dataset, "movie");
                my_data_table = my_dataset.Tables["movie"];




                for (int i = 0; i < my_data_table.Rows.Count; i++)
                {
                    dr = my_data_table.Rows[i];
                    String genre = dr.ItemArray[0].ToString();
                    Label genreLabel = new Label();
                    genreLabel.Text = genre;
                    genreLabel.AutoSize = true;
                    genrePanel.Controls.Add(genreLabel);

                }

                genrePanel.BorderStyle = BorderStyle.FixedSingle;

                SQL = "SELECT fname,lname FROM `person` ,actor Where person.SSN = actor.SSN AND actor.filmid = " + FilmId;
                my_data_adapter = new MySqlDataAdapter(SQL, conn);
                my_dataset = new DataSet();
                my_data_table = new DataTable();

                my_data_adapter.Fill(my_dataset, "movie");
                my_data_table = my_dataset.Tables["movie"];




                for (int i = 0; i < my_data_table.Rows.Count; i++)
                {
                    dr = my_data_table.Rows[i];
                    String fname = dr.ItemArray[0].ToString();
                    String lname = dr.ItemArray[1].ToString();
                    String actor = fname + " " + lname;
                    Label actorLabel = new Label();
                    actorLabel.Text = actor;
                    actorLabel.AutoSize = true;
                    actorPanel.Controls.Add(actorLabel);

                }

                actorPanel.BorderStyle = BorderStyle.FixedSingle;


                SQL = "SELECT fname,lname,text,rating FROM `movie_review`,person WHERE filmid = " + FilmId + " AND person.ssn = movie_review.ssn";
                my_data_adapter = new MySqlDataAdapter(SQL, conn);
                my_dataset = new DataSet();
                my_data_table = new DataTable();

                my_data_adapter.Fill(my_dataset, "movie");
                my_data_table = my_dataset.Tables["movie"];

                float avgRating = 0;
                for (int i = 0; i < my_data_table.Rows.Count; i++)
                {
                    dr = my_data_table.Rows[i];
                    String fname = dr.ItemArray[0].ToString();
                    String lname = dr.ItemArray[1].ToString();
                    String review = dr.ItemArray[2].ToString();
                    String ratingGiven = dr.ItemArray[3].ToString();
                    avgRating += Convert.ToSingle(ratingGiven);
                    TableLayoutPanel panel = new TableLayoutPanel();

                    Label name = new Label();
                    name.Text = fname + " " + lname + " - " + ratingGiven;
                    name.AutoSize = true;
                    name.ForeColor = Color.Firebrick;

                    TextBox tb = new TextBox();
                    tb.Text = review;
                    tb.Enabled = false;
                    tb.WordWrap = true;
                    tb.Height = 4;
                    tb.Width = this.Width / 2 + this.Width / 3;

                    panel.Controls.Add(name, 0, 0);
                    panel.Controls.Add(tb, 0, 1);
                    panel.AutoSize = true;

                    ReviewsPanel.Controls.Add(panel, 0, i);
                    ReviewsPanel.AutoScroll = true;
                }
                if (my_data_table.Rows.Count > 0)
                {
                    avgRating = avgRating / my_data_table.Rows.Count;
                }
                else
                {
                    avgRating = 0;

                }
                avg_rating.Text = avgRating.ToString("#.##");
                avg_rating_progress.Value = (int)avgRating;
                if (String.IsNullOrEmpty(loggedInUserSSN) || loggedInUserSSN.Equals("0000000"))
                {
                    textBox1.Visible = false;
                    label1.Visible = false;
                    reviewLabel.Visible = false;
                    recommendCB.Visible = false;
                }
                else
                {


                    SQL = "SELECT rating FROM `movie_review` WHERE filmid = " + FilmId + " AND ssn=" + loggedInUserSSN;
                    my_data_adapter = new MySqlDataAdapter(SQL, conn);
                    my_dataset = new DataSet();
                    my_data_table = new DataTable();

                    my_data_adapter.Fill(my_dataset, "movie");
                    my_data_table = my_dataset.Tables["movie"];

                    if (my_data_table.Rows.Count != 0)
                    {
                        dr = my_data_table.Rows[0];
                        textBox1.Text = dr[0].ToString();

                        textBox1.Visible = true;
                        label1.Visible = true;

                    }
                    else
                    {
                        textBox1.Visible = false;
                        label1.Visible = false;

                    }

                }
                if (String.IsNullOrEmpty(SSN) || SSN.Equals("0000000"))
                {
                    recommendCB.Visible = false;
                    reviewLabel.Visible = false;
                }
                else
                {
                    recommendCB.Visible = true;
                    reviewLabel.Visible = true;


                    conn = new MySqlConnection(s);
                    conn.Open();
                    SQL = "Select SSN from recommend where filmid =" + filmId + " AND SSN =" + loggedInUserSSN;
                    my_data_adapter = new MySqlDataAdapter(SQL, conn);
                    my_dataset = new DataSet();
                    my_data_table = new DataTable();

                    my_data_adapter.Fill(my_dataset, "recommend");
                    my_data_table = my_dataset.Tables["recommend"];

                    if (my_data_table.Rows.Count > 0)
                    {
                        recommendCB.Checked = true;

                    }
                    else
                    {
                        recommendCB.Checked = false;
                    }



                }
                fetchTheatresPlayingIn();

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }



        }

        public void fetchTheatresPlayingIn()
        {

            try
            {
                conn = new MySqlConnection(s);
                conn.Open();
                String SQL = "Select name from theater,(Select distinct TID from now_playing where filmid='" + filmId + "') as temp where theater.tid=temp.tid";
                my_data_adapter = new MySqlDataAdapter(SQL, conn);
                my_dataset = new DataSet();
                my_data_table = new DataTable();

                my_data_adapter.Fill(my_dataset, "movie");
                my_data_table = my_dataset.Tables["movie"];

                for (int i = 0; i < my_data_table.Rows.Count; i++)
                {
                    DataRow dr = my_data_table.Rows[i];
                    String theaterName = dr[0].ToString();
                    LinkLabel t = new LinkLabel();
                    t.Click += new EventHandler(t_Click);
                    t.Text = theaterName;
                    theatrePanel.Controls.Add(t);



                }




            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }





        }

        void t_Click(object sender, EventArgs e)
        {
            try
            {

                conn = new MySqlConnection(s);
                conn.Open();
                String SQL = "Select date,time from now_playing where filmid='" + filmId + "' And tid=(Select tid from theater where name ='" + (sender as LinkLabel).Text + "')";
                my_data_adapter = new MySqlDataAdapter(SQL, conn);
                my_dataset = new DataSet();
                my_data_table = new DataTable();

                my_data_adapter.Fill(my_dataset, "movie");
                my_data_table = my_dataset.Tables["movie"];
                ShowTimeAndDatePanel popUp = new ShowTimeAndDatePanel();

                for (int i = 0; i < my_data_table.Rows.Count; i++)
                {
                    DataRow dr = my_data_table.Rows[i];
                    String date = dr[0].ToString().Split(' ')[0];
                    String time = dr[1].ToString();

                    Label temp = new Label();
                    temp.Text = "Show " + (i + 1) + " : " + "Date: " + date + "  Time:" + time;
                    temp.AutoSize = true;
                    TableLayoutPanel tpanel = (TableLayoutPanel)popUp.Controls[1];
                    tpanel.Controls.Add(temp);

                }
                popUp.ShowDialog();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void description_TextChanged(object sender, EventArgs e)
        {




        }

        private void reviewLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            write_update_reviewForm reviewForm = new write_update_reviewForm(filmId, loggedInUserSSN);
            reviewForm.ShowDialog();

        }

        private void ReviewsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void recommendCB_CheckedChanged(object sender, EventArgs e)
        {
            if(screenLoaded){
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = "server=localhost; userid=root;password=;database=moviedb;";
            conn.Open();
            String SQL;
            if (recommendCB.Checked)
            {
                SQL = "INSERT INTO `recommend`(`SSN`, `filmid`) VALUES (" + loggedInUserSSN+","+filmId+")";

            }
            else
            {   //remove from DB

                SQL = "Delete from recommend where SSN = "+loggedInUserSSN+" and filmid= "+filmId;


            }
            cmd.Connection = conn;
            cmd.CommandText = SQL;
            cmd.ExecuteNonQuery();
            conn.Close();
            }
        }

    }
}
