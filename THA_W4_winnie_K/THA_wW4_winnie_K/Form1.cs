using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_wW4_winnie_K
{
    public partial class Form1 : Form
    {
        private Form SecondForm;
        public static Form1 instance;
        public Boolean SecondFormisopen = false;
        public Button btnsubmit;
        public Form1()
        {
            InitializeComponent();
            instance = this;
            btnsubmit = button2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SecondForm = new Form2();
            SecondForm.Show();
            SecondFormisopen = true;
            if (checkBox1.Checked)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBox1.Checked) && (SecondFormisopen))
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") && (textBox2.Text == ""))
            {
                string message = "Please enter the correct input!";
                MessageBox.Show(message);
            }
            else
            {
                String teks = "Hi, my name is " + textBox1.Text + " and my favorite artist is " + textBox2.Text;
                Form2.instance.labelEdit.Text = teks;
            }
        }
    }


}
