using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_final.Models;

namespace Proyecto_final
{
    public partial class Approved : Form
    {
        Appointment approvedAppointment;
        public Approved(Appointment a)
        {
            approvedAppointment = a;
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = approvedAppointment.DuiNavigation.NamePerson;
            label3.Text = approvedAppointment.DuiNavigation.Age.ToString();
            label4.Text = approvedAppointment.DuiNavigation.BelongingInstitutionNavigation.NameInstitution;
            if (approvedAppointment.IsSecondAppointment)
                label5.Text = "segunda";
            label6.Text = approvedAppointment.IdCabinNavigation.AddressCabin;
            label8.Text = approvedAppointment.DateHourAppointment.ToString();
        }







        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font tipotexto = new Font("Arial", 12, FontStyle.Bold);
            Font logo = new Font("Times New Roman", 22, FontStyle.Bold);

            
            e.Graphics.DrawString(Ap_log2.Text, logo, Brushes.Black, 430, 600);
            e.Graphics.DrawString(txtAp_1.Text, tipotexto, Brushes.Black, 30, 100);
            e.Graphics.DrawString(label2.Text, tipotexto, Brushes.Black, 130, 100);
            e.Graphics.DrawString(txtAp_2.Text, tipotexto, Brushes.Black, 310, 100);
            e.Graphics.DrawString(label3.Text, tipotexto, Brushes.Black, 385, 100);
            e.Graphics.DrawString(txtAp_3.Text, tipotexto, Brushes.Black, 435, 100);
            e.Graphics.DrawString(label4.Text, tipotexto, Brushes.Black, 750, 100);
            e.Graphics.DrawString(txtAp_4.Text, tipotexto, Brushes.Black, 30, 150);
            e.Graphics.DrawString(label5.Text, tipotexto, Brushes.Black, 330, 150);
            e.Graphics.DrawString(txtAp_5.Text, tipotexto, Brushes.Black, 490, 150);
            e.Graphics.DrawString(label8.Text, tipotexto, Brushes.Black, 700, 150);
            e.Graphics.DrawString(label7.Text, tipotexto, Brushes.Black, 30, 200);
            e.Graphics.DrawString(label6.Text, tipotexto, Brushes.Black, 90, 200);
            e.Graphics.DrawString(txtAp_7.Text, tipotexto, Brushes.Black, 30, 250);










        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Show();
        }

        private void Ap_log_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
