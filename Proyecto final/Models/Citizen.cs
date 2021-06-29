﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_final.Models
{
    public partial class Citizen
    {
        public Citizen()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int Dui { get; set; }
        public string NamePerson { get; set; }
        public int Age { get; set; }
        public string AddressCitizen { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string DiseaseSuffer { get; set; }
        public int BelongingInstitution { get; set; }
        public int IdCabin { get; set; }

        public virtual Institution BelongingInstitutionNavigation { get; set; }
        public virtual Cabin IdCabinNavigation { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
