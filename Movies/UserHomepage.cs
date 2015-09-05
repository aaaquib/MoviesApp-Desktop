using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.IO;

namespace Movies
{
    public partial class UserHomepage : Form
    {
        bool action; bool adventure; bool animation; bool biography; bool comedy; bool crime; bool documentary; bool drama;
        bool fantasy; bool horror; bool musical; bool romance; bool scifi; bool sport; bool thriller; bool war;

        String Username = "anton";
        String useridQuery;
        int ssn;
        String reviews;
        String popular;
        String recommended;
        String Preferences;
        String listOfAllMovies;
        public string s = "server=localhost;User Id=root;database=moviedb";
        MySqlConnection conn;
        MySqlDataAdapter da;
        DataSet ds;
        DataTable dt;
        MySqlCommand cmd;
        AutoCompleteStringCollection allmovies;
        public UserHomepage()
        {
            InitializeComponent();
        }

        public UserHomepage(String username)
        {
            this.Username = username;
            conn = new MySqlConnection(s);
            cmd = new MySql.Data.MySqlClient.MySqlCommand();

            useridQuery = "Select SSN FROM user WHERE Username='" + Username + "';";

            try
            {

                conn.Open();
                da = new MySqlDataAdapter(useridQuery, conn);
                ds = new DataSet();
                dt = new DataTable();
                da.Fill(ds, "userid");
                dt = ds.Tables["userid"];
                DataRow dr = dt.Rows[0];
                ssn = Convert.ToInt32(dr[0]);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }

            reviews = "Select m.title,r.Rating,r.Text FROM movie m,movie_review r WHERE m.filmID=r.filmID AND SSN=" + ssn;
            //popular = "Select title from movie m,genre g where m.filmID=g.filmID AND g.genre IN (Select genre FROM Likes WHERE SSN = (SELECT SSN FROM user WHERE username='" + Username + "')) AND Avg_rating>=7.5 AND title IN (SELECT m.title FROM movie m,recommend r WHERE m.filmID=r.filmID GROUP BY m.title HAVING COUNT(*)>=5)";
            popular = "SELECT  DISTINCT m.title FROM movie m,recommend r WHERE m.filmID=r.filmID AND Avg_rating>=7.5 GROUP BY m.title HAVING COUNT(*)>=2";
            recommended = "SELECT DISTINCT m.title FROM movie m,recommend r WHERE m.filmID=r.filmID AND r.SSN IN (SELECT l1.SSN FROM Likes l1,Likes l2 Where l1.genre=l2.genre AND l2.SSN = " + ssn + " AND l1.SSN < l2.SSN)";
            Preferences = "Select genre FROM Likes WHERE SSN = " + ssn;
            listOfAllMovies = "Select distinct title from movie";
            InitializeComponent();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string text = searchBox.Text;
            SearchResult sr = new SearchResult(text,ssn);
            sr.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String genre;
                if (conn.State == ConnectionState.Open)
                {

                    da = new MySqlDataAdapter(Preferences, conn);
                    ds = new DataSet();
                    dt = new DataTable();
                    da.Fill(ds, "pref");
                    dt = ds.Tables["pref"];
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            genre = dr[0].ToString();
                            if (genre == "Action")
                            {
                                action = true;
                                checkBoxAction.CheckState = CheckState.Checked;
                            }
                            if (genre == "Adventure")
                            {
                                adventure = true;
                                checkBoxAdventure.CheckState = CheckState.Checked;
                            }
                            if (genre == "Animation")
                            {
                                animation = true;
                                checkBoxAnimation.CheckState = CheckState.Checked;
                            }
                            if (genre == "Biography")
                            {
                                biography = true;
                                checkBoxBiography.CheckState = CheckState.Checked;
                            }
                            if (genre == "Comedy")
                            {
                                comedy = true;
                                checkBoxComedy.CheckState = CheckState.Checked;
                            }
                            if (genre == "Crime")
                            {
                                crime = true;
                                checkBoxCrime.CheckState = CheckState.Checked;
                            }
                            if (genre == "Documentary")
                            {
                                documentary = true;
                                checkBoxDocumentary.CheckState = CheckState.Checked;
                            }
                            if (genre == "Drama")
                            {
                                drama = true;
                                checkBoxDrama.CheckState = CheckState.Checked;
                            }
                            if (genre == "Fantasy")
                            {
                                fantasy = true;
                                checkBoxFantasy.CheckState = CheckState.Checked;
                            }
                            if (genre == "Horror")
                            {
                                horror = true;
                                checkBoxHorror.CheckState = CheckState.Checked;
                            }
                            if (genre == "Musical")
                            {
                                musical = true;
                                checkBoxMusical.CheckState = CheckState.Checked;
                            }
                            if (genre == "Romance")
                            {
                                romance = true;
                                checkBoxRomance.CheckState = CheckState.Checked;
                            }
                            if (genre == "Sci-Fi")
                            {
                                scifi = true;
                                checkBoxScifi.CheckState = CheckState.Checked;
                            }
                            if (genre == "Sport")
                            {
                                sport = true;
                                checkBoxSport.CheckState = CheckState.Checked;
                            }
                            if (genre == "Thriller")
                            {
                                thriller = true;
                                checkBoxThriller.CheckState = CheckState.Checked;
                            }
                            if (genre == "War")
                            {
                                war = true;
                                checkBoxWar.CheckState = CheckState.Checked;
                            }
                        }
                    }

                    panel4.AutoScroll = true;

                    panel3.BackColor = Color.WhiteSmoke;
                    panel3.AutoScroll = true;

                    da = new MySqlDataAdapter(popular, conn);
                    ds = new DataSet();
                    dt = new DataTable();
                    da.Fill(ds, "pop");
                    dt = ds.Tables["pop"];
                    if (dt.Rows.Count > 0)
                    {
                        int i = 0;
                        //Point loc = new Point(5,5);
                        foreach (DataRow dr in dt.Rows)
                        {
                            string title = dr[0].ToString();
                            LinkLabel l = new LinkLabel();
                            panel3.Controls.Add(l);
                            l.Name = title;
                            l.Location = new Point(l.Location.X, 18 * i);
                            //l.Height = 12;
                            //l.Width = 150;
                            //l.Location 
                            //loc += 5;
                            //loc.Y += l.Height + 5;
                            l.Text = title;
                            l.AutoSize = true;
                            l.Links.Add(0, l.Text.Length, l.Text);
                            l.LinkClicked += new LinkLabelLinkClickedEventHandler(l_LinkClicked);

                            //l.Top = loc;
                            i++;
                        }
                    }

                    populateReviewPanel();




                    //code for auto complete feature starts here
                    da = new MySqlDataAdapter(listOfAllMovies, conn);
                    ds = new DataSet();
                    dt = new DataTable();
                    da.Fill(ds, "allMovies");
                    dt = ds.Tables["allMovies"];
                    allmovies = new AutoCompleteStringCollection();
                    if (dt.Rows.Count > 0)
                    {

                        foreach (DataRow dr in dt.Rows)
                        {
                            string title = dr[0].ToString();
                            allmovies.Add(title);

                        }
                    }
                    searchBox.AutoCompleteCustomSource = allmovies;
                    //code for auto complete feature ends here




                }
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        void populateReviewPanel()
        {
            panel2.Controls.Clear();
            panel2.AutoScroll = true;
            panel2.BackColor = Color.WhiteSmoke;

            da = new MySqlDataAdapter(reviews, conn);
            ds = new DataSet();
            dt = new DataTable();
            da.Fill(ds, "rev");
            dt = ds.Tables["rev"];
            if (dt.Rows.Count > 0)
            {
                int i = 0;
                //Point loc = new Point(5,5);
                foreach (DataRow dr in dt.Rows)
                {
                    string title = dr[0].ToString();
                    string rating = dr[1].ToString();
                    string text = dr[2].ToString();
                    FlowLayoutPanel flp = new FlowLayoutPanel();
                    panel2.Controls.Add(flp);
                    flp.Name = title;
                    flp.Location = new Point(flp.Location.X, 20 * i);

                    LinkLabel t = new LinkLabel();
                    Label r = new Label();
                    Label txt = new Label();
                    LinkLabel delete = new LinkLabel();

                    flp.Controls.Add(t);
                    flp.Controls.Add(r);
                    flp.Controls.Add(txt);
                    flp.Controls.Add(delete);

                    t.Text = title;
                    r.Text = "   " + rating; r.ForeColor = Color.Red;
                    txt.Text = "   " + text;
                    delete.Text = "  Delete";

                    t.Links.Add(0, t.Text.Length, t.Text);
                    t.LinkClicked += new LinkLabelLinkClickedEventHandler(l_LinkClicked);

                    delete.Links.Add(2, delete.Text.Length, t.Text);
                    delete.LinkClicked += new LinkLabelLinkClickedEventHandler(delete_LinkClicked);

                    delete.AutoSize = true;
                    t.AutoSize = true;
                    r.AutoSize = true;
                    txt.AutoSize = true;
                    //flp.Text = title;
                    //flp.AutoSize = true;
                    flp.Height = 16;
                    flp.Width = 450;
                    //foreach (Control c in flp.Controls)
                    //{

                    //}
                    //l.Top = loc;
                    i++;
                }
            }
        }

        void delete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string title = e.Link.LinkData.ToString();
            cmd.Connection = conn;

            if (conn.State != ConnectionState.Open)
                conn.Open();
            try
            {
                da = new MySqlDataAdapter("SELECT filmID FROM movie WHERE title='" + title + "';", conn);
                ds = new DataSet();
                dt = new DataTable();
                da.Fill(ds, "fid");
                dt = ds.Tables["fid"];
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    int fid = Convert.ToInt32(dr[0]);

                    cmd.CommandText = "DELETE FROM movie_review WHERE SSN=" + ssn + " AND filmID=" + fid + ";";
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Your review for " + title + " has been deleted");
                        //panel2.Controls.Remove(panel2.Controls.Find(title, true)[0]);
                        populateReviewPanel();
                        panel2.Refresh();
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }

        void l_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //throw new NotImplementedException();
            string id;
            string title = e.Link.LinkData.ToString();

            if (conn.State != ConnectionState.Open)
                conn.Open();
            try
            {
                da = new MySqlDataAdapter("SELECT filmID FROM movie WHERE title='" + title + "';", conn);
                ds = new DataSet();
                dt = new DataTable();
                da.Fill(ds, "fid");
                dt = ds.Tables["fid"];
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    id = dr[0].ToString();
                    Movie_HomePage moviePage = new Movie_HomePage(id, ssn.ToString());
                    moviePage.Show();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }

        private void checkBoxAction_CheckedChanged(object sender, EventArgs e)
        {

            action = updateUserPreferences(checkBoxAction, "Action", action);
            fetchRecommendedMovies();

        }

        private void checkBoxAdventure_CheckedChanged(object sender, EventArgs e)
        {
            adventure = updateUserPreferences(checkBoxAdventure, "Adventure", adventure);
            fetchRecommendedMovies();
        }

        private void checkBoxAnimation_CheckedChanged(object sender, EventArgs e)
        {
            animation = updateUserPreferences(checkBoxAnimation, "Animation", animation);
            fetchRecommendedMovies();
        }

        private void checkBoxBiography_CheckedChanged(object sender, EventArgs e)
        {
            biography = updateUserPreferences(checkBoxBiography, "Biography", biography);
            fetchRecommendedMovies();

        }

        private void checkBoxComedy_CheckedChanged(object sender, EventArgs e)
        {

            comedy = updateUserPreferences(checkBoxComedy, "Comedy", comedy);
            fetchRecommendedMovies();
        }

        private void checkBoxCrime_CheckedChanged(object sender, EventArgs e)
        {
            crime = updateUserPreferences(checkBoxCrime, "Crime", crime);
            fetchRecommendedMovies();

        }

        private void checkBoxDocumentary_CheckedChanged(object sender, EventArgs e)
        {
            documentary = updateUserPreferences(checkBoxDocumentary, "Documentary", documentary);
            fetchRecommendedMovies();
        }

        private void checkBoxDrama_CheckedChanged(object sender, EventArgs e)
        {
            drama = updateUserPreferences(checkBoxDrama, "Drama", drama);
            fetchRecommendedMovies();

        }

        private void checkBoxFantasy_CheckedChanged(object sender, EventArgs e)
        {
            fantasy = updateUserPreferences(checkBoxFantasy, "Fantasy", fantasy);
            fetchRecommendedMovies();

        }

        private void checkBoxHorror_CheckedChanged(object sender, EventArgs e)
        {
            horror = updateUserPreferences(checkBoxHorror, "Horror", horror);
            fetchRecommendedMovies();
        }

        private void checkBoxMusical_CheckedChanged(object sender, EventArgs e)
        {
            musical = updateUserPreferences(checkBoxMusical, "Musical", musical);
            fetchRecommendedMovies();

        }

        private void checkBoxRomance_CheckedChanged(object sender, EventArgs e)
        {
            romance = updateUserPreferences(checkBoxRomance, "Romance", romance);
            fetchRecommendedMovies();

        }

        private void checkBoxScifi_CheckedChanged(object sender, EventArgs e)
        {
            scifi = updateUserPreferences(checkBoxScifi, "Sci-Fi", scifi);
            fetchRecommendedMovies();

        }

        private void checkBoxSport_CheckedChanged(object sender, EventArgs e)
        {
            sport = updateUserPreferences(checkBoxSport, "Sport", sport);
            fetchRecommendedMovies();
        }

        private void checkBoxThriller_CheckedChanged(object sender, EventArgs e)
        {
            thriller = updateUserPreferences(checkBoxThriller, "Thriller", thriller);
            fetchRecommendedMovies();
        }

        private void checkBoxWar_CheckedChanged(object sender, EventArgs e)
        {
            war = updateUserPreferences(checkBoxWar, "War", war);
            fetchRecommendedMovies();
        }

        public bool updateUserPreferences(CheckBox cb, string genre, bool change)
        {
            //goto database. if a checkbox is unchecked, remove from the likes table for that user. if it is checked, insert it into the likes 
            //table for that user
            cmd.Connection = conn;
            //try
            //{


            //da = new MySqlDataAdapter("Select * FROM Likes WHERE SSN = " + ssn + " AND genre='" + genre + "';", conn);
            //ds = new DataSet();
            //dt = new DataTable();
            //da.Fill(ds, "like");
            //dt = ds.Tables["like"];
            // }
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}

            if (cb.CheckState == CheckState.Checked)
            {
                if (!change)
                {
                    try
                    {
                        if (conn.State != ConnectionState.Open)
                            conn.Open();
                        cmd.CommandText = "INSERT INTO Likes(SSN,genre) Values (" + ssn + ",'" + genre + "');";
                        cmd.ExecuteNonQuery();
                        //conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        //conn.Close();
                    }
                }
                conn.Close();
                return true;
            }
            else
            {
                try
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    cmd.CommandText = "DELETE FROM Likes WHERE SSN = " + ssn + " AND genre = '" + genre + "';";
                    cmd.ExecuteNonQuery();

                    //conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    //conn.Close();
                }
                conn.Close();
                return false;
            }
        }

        public void fetchRecommendedMovies()
        {
            panel4.BackColor = Color.WhiteSmoke;
            //this method will fetch the recommended movies for a user based on likes
            try
            {
                while (panel4.Controls.Count > 0)
                {
                    panel4.Controls.RemoveAt(0);
                }
                conn.Open();
                string temp = "SELECT filmID,title from movie WHERE title IN (" + recommended + ")";
                string rec = "SELECT DISTINCT title FROM (" + temp + ") t, genre g WHERE t.filmID=g.filmID AND genre IN (" + Preferences + ")";
                //recommended = recommended + " AND genre IN (" + Preferences + ")";
                MySqlDataAdapter da = new MySqlDataAdapter(rec, conn);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds, "recommended");
                dt = ds.Tables["recommended"];
                if (dt.Rows.Count > 0)
                {
                    int i = 0;
                    //Point loc = new Point(5,5);
                    foreach (DataRow dr in dt.Rows)
                    {
                        string title = dr[0].ToString();
                        LinkLabel l = new LinkLabel();
                        panel4.Controls.Add(l);
                        l.Name = "rectitle" + i;
                        l.Location = new Point(l.Location.X, 18 * i);
                        //l.Height = 12;
                        //l.Width = 150;
                        //l.Location 
                        //loc += 5;
                        //loc.Y += l.Height + 5;
                        l.Text = title;
                        l.AutoSize = true;

                        l.Links.Add(0, l.Text.Length, l.Text);
                        l.LinkClicked += new LinkLabelLinkClickedEventHandler(l_LinkClicked);

                        //l.Top = loc;
                        i++;
                    }

                    panel4.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
            conn.Close();
        }

        private void LinkClicked(LinkLabel ll)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            movies_database_homepage.mainpage mp = new movies_database_homepage.mainpage();
            mp.Show();
            this.Close();
        }

    }
};
