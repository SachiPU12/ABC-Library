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
    public partial class Form4 : Form
    {
        SqlConnection myNewConnection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\ABC Library System\Project\Windows Forms Application8\WindowsFormsApplication8\Database1.mdf;Integrated Security=True;User Instance=True");
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                myNewConnection.Open();
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand("select * from Members where MemberID='" + textBox1.Text + "'", myNewConnection);
                SqlDataAdapter a = new SqlDataAdapter(cmd);
                a.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    textBox2.Text = ds.Tables[0].Rows[0]["FirstName"].ToString();
                    textBox3.Text = ds.Tables[0].Rows[0]["LastName"].ToString();
                    textBox4.Text = ds.Tables[0].Rows[0]["Address"].ToString();
                    textBox5.Text = ds.Tables[0].Rows[0]["NIC"].ToString();
                }
                else
                {
                    MessageBox.Show("Invalid Memeber ID..!");
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int MemberID = int.Parse(textBox1.Text);
            String FirstName = textBox2.Text;
            String LastName = textBox3.Text;
            String Address = textBox4.Text;
            String NIC = textBox5.Text;

            try
            {
                myNewConnection.Open();
                SqlCommand myCommand = new SqlCommand("UPDATE Members SET (FirstName,LastName,Address,NIC) values ('" + FirstName + "','" + LastName + "','" + Address + "','" + NIC + "')", myNewConnection);
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
    }
}
