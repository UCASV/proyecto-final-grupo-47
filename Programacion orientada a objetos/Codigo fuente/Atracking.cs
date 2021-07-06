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
    public partial class Atracking : Form
    {
        Login currentLogin;
        public Atracking(Login c)
        {
            currentLogin = c;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_si.Checked)
            {
                boxAt_enfermedades.Enabled = true;
                return;
            }
            boxAt_enfermedades.Enabled = false;
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (boxAt_nombres.Text == "" || boxAt_edad.Text == "" || boxAt_dui.Text == "" || boxAt_direccion.Text == "" || boxAt_telefono.Text == "")
            {
                MessageBox.Show("Uno o mas atributos requeridos estan vacios.");
                return;
            }

            uint age = 0;
            try
            {
                age = UInt32.Parse(boxAt_edad.Text);
            }
            catch
            {
                MessageBox.Show("Edad debe ser un numero entero positivo.");
                return;
            }

            if (boxAt_dui.Text.Length != 9)
            {
                MessageBox.Show("El DUI debe ser 9 digitos largo.");
                return;
            }
            uint dui = 0;
            try
            {
                dui = UInt32.Parse(boxAt_dui.Text);
            }
            catch
            {
                MessageBox.Show("El DUI debe contener solamente numeros.");
                return;
            }

            uint phone = 0;
            try
            {
                phone = UInt32.Parse(boxAt_telefono.Text);
            }
            catch
            {
                MessageBox.Show("El telefono debe contener solamente numeros.");
                return;
            }

            if (!(age >= 60 || (age >= 18 && chk_si.Checked) || ((Institution)comboBox1.SelectedItem).IsPriority))
            {
                MessageBox.Show("El paciente no pertence a un grupo de prioridad.");
                return;
            }

            var db = new project_dbContext();

            var user = db.Citizens.FirstOrDefault(u => u.Dui == (int)dui);
            if (user is not null)
            {

                MessageBox.Show("El DUI ingresado ya esta registrado.");


                return;
            }

            var cabins = db.Cabins.ToList();
            int leastAppoint = Int32.MaxValue;
            int leastId = 0;
            foreach (Cabin c in cabins)
            {
                int l = db.Appointments.Count(a => a.IdCabin == c.Id && a.DateHourAppointment >= DateTime.Now && a.CompletedAppointment == false);
                if (l < leastAppoint)
                {
                    leastAppoint = l;
                    leastId = c.Id;
                }
            }

            Appointment preiviouAppointment = db.Appointments.OrderBy(a => a.DateHourAppointment).LastOrDefault(a => a.IdCabin == leastId && a.DateHourAppointment >= DateTime.Now && a.CompletedAppointment == false);
            DateTime nextAvailable = DateTime.Today.AddDays(1).AddHours(10);
            
            if (preiviouAppointment is not null)
            {
                if (preiviouAppointment.DateHourPreCheck >= nextAvailable)
                {
                    nextAvailable = preiviouAppointment.DateHourAppointment.AddMinutes(45);
                    if (nextAvailable.TimeOfDay > new TimeSpan(17, 15, 0))
                        nextAvailable = nextAvailable.Date.AddDays(1).AddHours(10);
                }
                
            }

            string diseases = "";
            if (chk_si.Checked)
                diseases = boxAt_enfermedades.Text;

            Cabin cdb = db.Set<Cabin>().SingleOrDefault(u => u.Id == currentLogin.IdCabin);
            Institution iref = (Institution)comboBox1.SelectedItem;
            Institution idb = db.Set<Institution>().SingleOrDefault(u => u.Id == iref.Id);
            Citizen newCit = new Citizen((int)dui, boxAt_nombres.Text, (int)age, boxAt_direccion.Text, boxAt_correo.Text, phone.ToString(), diseases, idb, cdb);
            db.Add(newCit);
            db.SaveChanges();
            Cabin acdb = db.Set<Cabin>().SingleOrDefault(u => u.Id == leastId);
            Citizen ctdb = db.Set<Citizen>().SingleOrDefault(u => u.Dui == newCit.Dui);
            Employee redb = db.Set<Employee>().SingleOrDefault(u => u.Id == currentLogin.IdEmployee);
            Appointment newApp = new Appointment(nextAvailable, false, acdb, ctdb, redb);
            db.Add(newApp);
            db.SaveChanges();

            MessageBox.Show($"El paciente ha sido ingresado con exito!");
            Approved abrir = new Approved(newApp);
            this.Hide();
            abrir.ShowDialog();
            abrir.Dispose();
            this.Close();

        }

        private void Atracking_Load(object sender, EventArgs e)
        {
            var db = new project_dbContext();
            comboBox1.DataSource = db.Institutions.ToList();
            comboBox1.DisplayMember = "NameInstitution";
            comboBox1.ValueMember = "Id";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}