using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_final.Models
{
    public partial class AppointmentPlace
    {
        public AppointmentPlace()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int Id { get; set; }
        public string AppointmentPlace1 { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
