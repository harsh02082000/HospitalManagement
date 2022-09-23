using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_Entity
{
    public class Doctor
    {
        public string DoctorEmail { get; set; }
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string DoctorPassword { get; set; }

        public Doctor(int doctorId, string doctorName, string doctorEmail, string doctorPassword)
        {
            this.DoctorId = doctorId;
            this.DoctorName = doctorName;
            this.DoctorEmail = doctorEmail;
            this.DoctorPassword = doctorPassword;
        }
        public Doctor()
        {

        }
    }
}
