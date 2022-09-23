using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_Entity
{
    public class Prescription
    {
        public int PrescriptionId { get; set; } 
        public string PrescriptionDetails { get; set; }
        public DateTime PrescriptionDate { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public Prescription(int PrescriptionId, string PrescriptionDetails, DateTime PrescriptionDate, int PatientId, int DoctorId)
        {
            this.PrescriptionId = PrescriptionId;   
            this.PrescriptionDetails = PrescriptionDetails;
            this.PrescriptionDate = PrescriptionDate;
            this.PatientId = PatientId;
            this.DoctorId = DoctorId;
          
        }

        public Prescription()
        {

        }
    }
}
