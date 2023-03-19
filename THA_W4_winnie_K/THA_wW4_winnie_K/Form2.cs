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
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public Label labelEdit;
        public Form2()
        {
            InitializeComponent();
            instance = this;
            labelEdit = label3;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBox1.Checked) && (checkBox2.Checked))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBox1.Checked) && (checkBox2.Checked))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Color warnabg = Color.White, warnafg = Color.Black;
            Boolean bgset = true, fgset = true;
            if (radioButton1.Checked)
            {
                warnabg = Color.Red;
            }
            else if (radioButton2.Checked)
            {
                warnabg = Color.Green;
            }
            else if (radioButton3.Checked)
            {
                warnabg = Color.Blue;
            }
            else if (radioButton4.Checked)
            {
                warnabg = Color.White;
            }
            else if (radioButton5.Checked)
            {
                warnabg = Color.Pink;
            }
            else
            {
                bgset = false;
            }

            if (radioButton6.Checked)
            {
                warnafg = Color.Black;
            }
            else if (radioButton7.Checked)
            {
                warnafg = Color.Red;
            }
            else if (radioButton8.Checked)
            {
                warnafg = Color.Green;
            }
            else
            {
                fgset = false;
            }

            if ((bgset) && (fgset))
            {
                Form1.instance.BackColor = warnabg;
                Form1.instance.ForeColor = warnafg;
            }
            else
            {
                string message = "Please chose color from radio button!";
                MessageBox.Show(message);
            }
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.instance.SecondFormisopen = false;
            Form1.instance.btnsubmit.Enabled = false;
        }
    }
}
