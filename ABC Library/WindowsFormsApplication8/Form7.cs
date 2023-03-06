using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication8
{
    public partial class Form7 : Form
    {
        SqlConnection myNewConnection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\ABC Library System\Project\Windows Forms Application8\WindowsFormsApplication8\Database1.mdf;Integrated Security=True;User Instance=True");
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           try
            {
                myNewConnection.Open();
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand("select * from Books where BookID='" + textBox1.Text + "'", myNewConnection);
                SqlDataAdapter a = new SqlDataAdapter(cmd);
                a.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    textBox2.Text = ds.Tables[0].Rows[0]["BookName"].ToString();
                    textBox3.Text = ds.Tables[0].Rows[0]["AuthorName"].ToString();
                    textBox4.Text = ds.Tables[0].Rows[0]["ISBN"].ToString();
                    textBox5.Text = ds.Tables[0].Rows[0]["Price"].ToString();
                }
                else
                {
                    MessageBox.Show("Invalid Book Name..!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Some Error occured..!");
            }
            finally
            {
                myNewConnection.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int BookID = int.Parse(textBox1.Text);
            String BookName = textBox2.Text;
            String AuthorName = textBox3.Text;
            String ISBN = textBox4.Text;
            String Price = textBox5.Text;

            try
            {
                myNewConnection.Open();
                SqlCommand myCommand = new SqlCommand("UPDATE Books SET (BookName,AuthorName,ISBN,Price) values ('" + BookName + "','" + AuthorName + "','" + ISBN + "','" + Price + "')", myNewConnection);
                myCommand.ExecuteNonQuery();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }

            catch (SqlException)
            {
                MessageBox.Show("Please Check the SQL statments", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Faild to connect to database...");
            }
            finally
            {
                myNewConnection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
