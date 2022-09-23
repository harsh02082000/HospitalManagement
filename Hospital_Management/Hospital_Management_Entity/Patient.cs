using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_Entity
{
    public class Patient
    {
        public string PatientEmail { get; set; }
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string PatientPassword { get; set; }

        public Patient(int patientId, string patientName, string patientEmail, string patientPassword)
        {
            this.PatientId = patientId;
            this.PatientName = patientName;
            this.PatientEmail = patientEmail;
            this.PatientPassword = patientPassword;
        }
        public Patient()
        {

        }
    }
}
