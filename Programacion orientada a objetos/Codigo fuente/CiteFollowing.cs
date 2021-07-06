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
    public partial class CiteFollowing : Form
    {
        Login currentLogin;
        Appointment currentAppointment;
        public CiteFollowing(Login c)
        {
            currentLogin = c;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uint dui = 0;
            try
            {
                dui = UInt32.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("El DUI debe contener solamente numeros.");
                return;
            }
            var db = new project_dbContext();
            

            var appoint = db.Appointments.FirstOrDefault(u => u.Dui == (int)dui && !u.CompletedAppointment);
            if (appoint is null)
            {

                MessageBox.Show("No existen citas pendientes con el DUI ingresado.");
                return;
            }
            currentAppointment = appoint;
            var citizen = db.Citizens.FirstOrDefault(u => u.Dui == (int)dui);
            textBox2.Text = citizen.NamePerson;
            textBox9.Text = citizen.Age.ToString();
            textBox3.Text = citizen.AddressCitizen;
            textBox4.Text = citizen.Telephone;
            textBox5.Text = citizen.DiseaseSuffer;
            textBox6.Text = db.Institutions.FirstOrDefault(u => u.Id == citizen.BelongingInstitution).NameInstitution;
            textBox7.Text = appoint.DateHourAppointment.ToString();
            textBox10.Text = citizen.Email;
            textBox8.Text = db.Cabins.FirstOrDefault(u => u.Id == appoint.IdCabin).AddressCabin;
            if (appoint.IsSecondAppointment)
                label15.Text = "Segunda Cita";
            else
                label15.Text = "Primera Cita";


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentAppointment is null)
            {
                return;
            }
            VaccineProcess abrir = new VaccineProcess(currentLogin,currentAppointment);
            abrir.ShowDialog();
            abrir.Dispose();
            this.Close();
        }
    }
}
