using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input;
            string t_version;

            input = textBox1.Text;

            t_version = input.Substring(1, input.Length - 1);
            label3.Text = t_version + "ay";
            label2.Visible = true; 
            label3.Visible = true;
        }
    }
}
