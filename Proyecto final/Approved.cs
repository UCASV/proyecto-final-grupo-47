using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio_de_sesion
{
    public partial class Approved : Form
    {
        public Approved()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font tipotexto = new Font("Arial", 12, FontStyle.Bold);
            Font logo = new Font("Times New Roman", 22, FontStyle.Bold);

            e.Graphics.DrawImage(Ap_log.Image, 170, 500);
            e.Graphics.DrawString(Ap_log2.Text, logo, Brushes.Black, 430, 600);
            e.Graphics.DrawString(txtAp_1.Text, tipotexto, Brushes.Black, 30, 100);
            e.Graphics.DrawString(boxAp_1.Text, tipotexto, Brushes.Black, 130, 100);
            e.Graphics.DrawString(txtAp_2.Text, tipotexto, Brushes.Black, 310, 100);
            e.Graphics.DrawString(boxAp_2.Text, tipotexto, Brushes.Black, 385, 100);
            e.Graphics.DrawString(txtAp_3.Text, tipotexto, Brushes.Black, 435, 100);
            e.Graphics.DrawString(boxAp_3.Text, tipotexto, Brushes.Black, 750, 100);
            e.Graphics.DrawString(txtAp_4.Text, tipotexto, Brushes.Black, 30, 150);
            e.Graphics.DrawString(boxAp_4.Text, tipotexto, Brushes.Black, 330, 150);
            e.Graphics.DrawString(txtAp_5.Text, tipotexto, Brushes.Black, 490, 150);
            e.Graphics.DrawString(boxAp_5.Text, tipotexto, Brushes.Black, 700, 150);
            e.Graphics.DrawString(txtAp_6.Text, tipotexto, Brushes.Black, 30, 200);
            e.Graphics.DrawString(boxAp_6.Text, tipotexto, Brushes.Black, 90, 200);
            e.Graphics.DrawString(txtAp_7.Text, tipotexto, Brushes.Black, 30, 250);










        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Show();
        }
    }
}
