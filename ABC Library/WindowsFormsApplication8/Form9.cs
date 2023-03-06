using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApplication8
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection myNewConnection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\ABC Library System\Project\Windows Forms Application8\WindowsFormsApplication8\Database1.mdf;Integrated Security=True;User Instance=True");
        
            int LoanID = int.Parse(textBox1.Text);
            int MemberID = int.Parse(textBox2.Text);
            int BookID = int.Parse(textBox3.Text);
            DateTime StartingDate = Convert.ToDateTime (dateTimePicker1.Text);
            DateTime ExpiringDate = Convert.ToDateTime (dateTimePicker2.Text);

            try
            {
                myNewConnection.Open();
                SqlCommand myCommand = new SqlCommand("insert into BookLoan (LoanID,MemberID,BookID,StartingDate,ExpiringDate) values ('"+LoanID+"','"+MemberID+"','"+BookID+"','"+StartingDate+"','"+ExpiringDate+"')", myNewConnection);
                myCommand.ExecuteNonQuery();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
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
    }
}
