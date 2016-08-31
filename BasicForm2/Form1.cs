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

        private double textBox1_TextChanged()
        {
            string work = Console.ReadLine();
            double hwork = Convert.ToDouble(work);
            return hwork;
        }

        private double textBox2_TextChanged()
        {
            string pay = Console.ReadLine();
            double hpay;
            double.TryParse(pay, out hpay);
            return hpay;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Calculate the gross pay
            //decimal hwork = textBox1.Text();
            //decimal hpay = textBox2.Text();
            //decimal cal = (Decimal.hwork * Decimal.hpay);
            //MessageBox.Show("The Gross Pay is {0}", cal.ToString("c"));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear the data
            textBox1.Clear();
            textBox2.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Close the program
            this.Close();
        }
    }
}
