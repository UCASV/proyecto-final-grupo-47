﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_final.Models
{
    public partial class Login
    {
        public int Id { get; set; }
        public int IdCabin { get; set; }
        public int IdEmployee { get; set; }
        public DateTime SessionStartDate { get; set; }

        public virtual Cabin IdCabinNavigation { get; set; }
        public virtual Employee IdEmployeeNavigation { get; set; }
    }
}
