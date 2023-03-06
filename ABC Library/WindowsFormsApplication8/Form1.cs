using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "abc";
            string password = "abc123";
            if ((textBox1.Text == username) && (textBox2.Text == password))
            {
                this.Hide();
                var Form2 = new Form2();
                Form2.Show();
            }
            else {
                MessageBox.Show("Incorrect Username or Password");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
