using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicForm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Calculate the gross pay
            decimal hwork = Decimal.Parse(textBox1.Text);
            decimal hpay = Decimal.Parse(textBox2.Text);
            decimal cal = (hwork * hpay);

            // Write the gross pay in textBox3
            textBox3.Text = cal.ToString("c");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Clear the data
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Close the program
            this.Close();
        }


    }
}
