using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_Entity
{
    public class Bill
    {
        public int BillId { get; set; }
        public int BillAmount { get; set; }
        public int PrescriptionId { get; set; }
        public int PatientId { get; set; }

        public Bill(int billId, int billAmount, int prescriptionId, int patientId)
        {
            this.BillId = billId;
            this.BillAmount = billAmount;
            this.PrescriptionId = prescriptionId;
            this.PatientId = patientId;
        }
        public Bill()
        {

        }
    }
}
