using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_Entity
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public Appointment(int appointmentId, DateTime appointmentDate, int patientId, int doctorId)
        {
            this.AppointmentId = appointmentId;
            this.AppointmentDate = appointmentDate;
            this.PatientId = patientId;
            this.DoctorId = doctorId;
        }   
        public Appointment()
        {

        }
    }
}
