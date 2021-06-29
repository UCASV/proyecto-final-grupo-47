﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_final.Models
{
    public partial class Institution
    {
        public Institution()
        {
            Citizens = new HashSet<Citizen>();
        }

        public int Id { get; set; }
        public string NameInstitution { get; set; }
        public bool IsPriority { get; set; }

        public virtual ICollection<Citizen> Citizens { get; set; }
    }
}
