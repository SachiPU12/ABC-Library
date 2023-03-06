using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    public partial class Form3 : Form
    {
        SqlConnection myNewConnection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\ABC Library System\Project\Windows Forms Application8\WindowsFormsApplication8\Database1.mdf;Integrated Security=True;User Instance=True");
        public Form3()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int MemberID = int.Parse(textBox1.Text);
            String FirstName = textBox2.Text;
            String LastName = textBox3.Text;
            String Address = textBox4.Text;
            String NIC = textBox5.Text;

            try
            {
                myNewConnection.Open();
                SqlCommand myCommand = new SqlCommand("insert into Members (MemberID,FirstName,LastName,Address,NIC) values ('" + MemberID + "','" + FirstName + "','" + LastName + "','" + Address + "','" + NIC + "')", myNewConnection);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}