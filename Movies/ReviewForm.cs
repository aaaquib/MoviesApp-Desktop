using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using MySql.Data.MySqlClient;

using System.IO;

using System.Data.Odbc;

namespace Movies
{
    public partial class write_update_reviewForm : Form
    {
        public String s = "server=localhost;User Id=root;database=moviedb";
        public MySqlDataAdapter my_data_adapter;
        MySqlConnection conn;
        MySqlCommand cmd;
        public DataSet my_dataset;
        public DataTable my_data_table;
        public MySqlDataReader mrdr;
        DataRow dr;
        bool ratingAlreadyExists;
        String filmID;
        String SSN;
        public OdbcConnection db;
       



        public write_update_reviewForm(String FilmId,String personSSN)
        {

            InitializeComponent();
            filmID = FilmId;
            SSN = personSSN;
            String SQL = "";
            conn = new MySqlConnection(s);
            conn.Open();
            SQL = "SELECT text,rating FROM `movie_review` WHERE filmid = " + FilmId + " AND ssn = "+personSSN;
            my_data_adapter = new MySqlDataAdapter(SQL, conn);
            my_dataset = new DataSet();
            my_data_table = new DataTable();

            my_data_adapter.Fill(my_dataset, "movie");
            my_data_table = my_dataset.Tables["movie"];

          
            if (my_data_table.Rows.Count!=0)
            {
                dr = my_data_table.Rows[0];
                String review = dr[0].ToString();
                String rating = dr[1].ToString();

                reviewBox.Text = review;
                ratingSpinner.Value = Convert.ToInt32(rating);
                ratingAlreadyExists = true; // just have to update the entry in database on save button click
            }
            else {
                ratingAlreadyExists = false;//have to insert a new entry in database on save button click
            }


        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            //insert into database
            try { 

                int rating = (int) ratingSpinner.Value;
                String review = reviewBox.Text;
                cmd = new MySql.Data.MySqlClient.MySqlCommand();
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = "server=localhost; userid=root;password=;database=moviedb;";
                conn.Open();
                String SQL;
               if(ratingAlreadyExists){
                 SQL = "UPDATE movie_review SET text='"+review+"',rating="+rating+" WHERE filmId="+filmID+" and SSN = "+SSN;
                

                
               }
               else
               {
                   SQL = "INSERT INTO `movie_review`(`filmID`, `SSN`, `Text`, `Rating`) VALUES (" + filmID + "," + SSN + ",'" + review + "'," + rating + ")";

               }

               cmd.Connection = conn;
               cmd.CommandText = SQL;
               cmd.ExecuteNonQuery();
               conn.Close();

                this.Dispose();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
