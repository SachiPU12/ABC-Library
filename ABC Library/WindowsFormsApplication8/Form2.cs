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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            this.MaximizeBox = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 ns = new Form3();
            ns.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 anb = new Form4();
            anb.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 ec = new Form5();
            ec.Show();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form6 eb = new Form6();
            eb.Show();
        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form7 es = new Form7();
            es.Show();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form8 ss = new Form8();
            ss.Show();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bookLoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 mn = new Form9();
            mn.Show();
        }
    } 
}
    