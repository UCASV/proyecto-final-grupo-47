using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_final.Models
{
    public partial class Cabin
    {
        public Cabin()
        {
            Appointments = new HashSet<Appointment>();
            Citizens = new HashSet<Citizen>();
            Logins = new HashSet<Login>();
        }

        public int Id { get; set; }
        public string AddressCabin { get; set; }
        public int IdManager { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }

        public virtual Employee IdManagerNavigation { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Citizen> Citizens { get; set; }
        public virtual ICollection<Login> Logins { get; set; }
    }
}
