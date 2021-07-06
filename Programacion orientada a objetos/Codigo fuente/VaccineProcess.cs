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
    public partial class VaccineProcess : Form
    {
        Login currentLogin;
        Appointment currentAppointment;
        public VaccineProcess(Login l, Appointment a)
        {
            currentLogin = l;
            currentAppointment = a;
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint duration = 0;
            try
            {
                duration = UInt32.Parse(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Tiempo en minutos debe ser un numero entero positivo.");
                return;
            }

            var db = new project_dbContext();
            Appointment apdb = db.Set<Appointment>().SingleOrDefault(u => u.Id == currentAppointment.Id);
            apdb.DateHourPreCheck = dateTimePicker1.Value;
            apdb.DateHourVaccine = dateTimePicker2.Value;
            apdb.SecondaryEffect = textBox1.Text;
            apdb.SecondaryEffectDuration = TimeSpan.FromMinutes(duration);
            apdb.CompletedAppointment = true;
            db.SaveChanges();

            if (!currentAppointment.IsSecondAppointment)
            {
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

                Cabin acdb = db.Set<Cabin>().SingleOrDefault(u => u.Id == leastId);
                Citizen ctdb = db.Set<Citizen>().SingleOrDefault(u => u.Dui == currentAppointment.Dui);
                Employee redb = db.Set<Employee>().SingleOrDefault(u => u.Id == currentLogin.IdEmployee);
                Appointment newApp = new Appointment(nextAvailable, true, acdb, ctdb, redb);
                db.Add(newApp);
                db.SaveChanges();
            }
            this.Close();            
        }
    }
}
