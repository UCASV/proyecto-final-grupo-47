using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_final.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Appointments = new HashSet<Appointment>();
            Cabins = new HashSet<Cabin>();
            Logins = new HashSet<Login>();
        }

        public int Id { get; set; }
        public string NameEmployee { get; set; }
        public string AddressEmployee { get; set; }
        public string Telephone { get; set; }
        public string InstitutionalMail { get; set; }
        public int IdEmployeeType { get; set; }
        public string UserEmployee { get; set; }
        public string PasswordEmployee { get; set; }

        public virtual EmployeeType IdEmployeeTypeNavigation { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Cabin> Cabins { get; set; }
        public virtual ICollection<Login> Logins { get; set; }
    }
}
