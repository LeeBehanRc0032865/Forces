using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double A = double.Parse(textBox2.Text);
                double ans = sin(A);
                label1.Text = ans.ToString();

            }
            catch
            {
                MessageBox.Show("Enter a NUMBER");
            }
        }

        double sin(double A)
        {
            double rad = A / 180.0 * Math.PI;
            return Math.Sin(rad);
        }

        double inversesin(double A)
        {
            double rad = A / 180.0 * Math.PI;
            return Math.Asin(rad);
        }

        double cos(double A)
        {
            double rad = A / 180.0 * Math.PI;
            return Math.Cos(rad);
        }


        double inversecos(double A);













    }
}
 
