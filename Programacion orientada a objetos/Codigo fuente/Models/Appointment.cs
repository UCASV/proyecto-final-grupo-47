using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_final.Models
{
    public partial class Appointment
    {
        public Appointment()
        { }
        public Appointment(DateTime dateAppointment, bool isSecond, Cabin appointmentCabin, Citizen patient, Employee registeringEmployee)
        {
            DateHourAppointment = dateAppointment;
            SecondaryEffect = "";
            IsSecondAppointment = isSecond;
            CompletedAppointment = false;
            DuiNavigation = patient;
            Dui = patient.Dui;
            IdCabinNavigation = appointmentCabin;
            IdCabin = appointmentCabin.Id;
            IdEmployeeNavigation = registeringEmployee;
            IdEmployee = registeringEmployee.Id;

        }
        public int Id { get; set; }
        public DateTime DateHourAppointment { get; set; }
        public DateTime? DateHourPreCheck { get; set; }
        public DateTime? DateHourVaccine { get; set; }
        public string SecondaryEffect { get; set; }
        public TimeSpan? SecondaryEffectDuration { get; set; }
        public bool IsSecondAppointment { get; set; }
        public bool CompletedAppointment { get; set; }
        public int IdCabin { get; set; }
        public int Dui { get; set; }
        public int IdEmployee { get; set; }

        public virtual Citizen DuiNavigation { get; set; }
        public virtual Cabin IdCabinNavigation { get; set; }
        public virtual Employee IdEmployeeNavigation { get; set; }
    }
}
