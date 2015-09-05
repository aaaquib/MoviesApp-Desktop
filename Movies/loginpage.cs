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

namespace movies_database_homepage
{
    public partial class loginpage : Form
    {
        public String s = "server=localhost;User Id=root;database=moviedb";
        public MySqlConnection conn;
       // public MySqlDataReader mrdr;
        public MySqlDataAdapter my_data_adapter;
        public DataSet my_dataset;
        public DataTable my_data_table;
       // SqlDataReader rd;

        String called_button;
        public loginpage(String called_button)
        {
            this.called_button = called_button;
            InitializeComponent();
           
        }
        public loginpage()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                if (called_button.Equals("login"))
                {
                    splitContainer1.Panel1.Enabled = true;
                    splitContainer1.Panel2.Enabled = false;
                }
                else if (called_button.Equals("register"))
                {
                    splitContainer1.Panel2.Enabled = true;
                    splitContainer1.Panel1.Enabled = false;
                }
                conn = new MySqlConnection(s);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void splitContainer1_Panel1_Paint(object Form2, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object Form2, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainpage f1 = new mainpage();
            f1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainpage f1 = new mainpage();
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try 
            {
                String str;
                if (radioButton1.Checked)
                {
                    str = radioButton1.Text;
                }
                else
                {
                    str = radioButton2.Text;
                }
                String sql = "INSERT INTO `person`(`Fname`, `Lname`, `SSN`, `gender`) VALUES ('" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + str + "')";
                String sql1 = "INSERT INTO `user`(`username`, `password`, `SSN`) VALUES ('" + textBox6.Text + "','" + textBox7.Text + "','" + textBox5.Text + "')";
                my_data_adapter = new MySqlDataAdapter();
                my_data_adapter.InsertCommand = new MySqlCommand(sql, conn);
                //my_data_adapter.InsertCommand = new MySqlCommand(sql1, conn);
                if (conn.State == ConnectionState.Open)
                {
                    if(textBox7.Text.Equals(textBox8.Text))
                    {
                        my_data_adapter.InsertCommand.ExecuteNonQuery();
                        my_data_adapter.InsertCommand = new MySqlCommand(sql1, conn);
                        my_data_adapter.InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("user registered");
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                        textBox7.Clear();
                        textBox8.Clear();
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        splitContainer1.Panel1.Enabled = true;
                        splitContainer1.Panel2.Enabled = false;
                    }else
                    {
                        MessageBox.Show("passwords do not match");
                    }
                    
                }
                else
                {
                    MessageBox.Show("user did not register");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                String sql = "SELECT * FROM `user` WHERE Username='"+textBox1.Text+"'"; 
                if (conn.State == ConnectionState.Open)
                {
                    my_data_adapter = new MySqlDataAdapter(sql, conn);
                    my_dataset = new DataSet();
                    my_data_table = new DataTable();
                    my_data_adapter.Fill(my_dataset,"users");
                    my_data_table=my_dataset.Tables["users"];
                    if (my_data_table.Rows.Count > 0)
                    {
                        DataRow dr = my_data_table.Rows[0];
                        if(dr[2].Equals(textBox2.Text))
                        {
                            MessageBox.Show("Welcome "+dr[1]+" ");
                            Movies.UserHomepage uh = new Movies.UserHomepage(dr[1].ToString());
                            uh.Show();
                            this.Close();

                        }else
                        {
                            MessageBox.Show("Wrong password");
                            textBox2.Clear();
                        }
                    }
                    else 
                    {
                        MessageBox.Show("username not found");
                        textBox1.Clear();
                        textBox2.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("not open");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
 
    }
}
