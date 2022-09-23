using Hospital_Management_Data;
using Hospital_Management_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_Bussiness
{
    public class PatientBLL
    {
        List<Patient> dalPatient = new List<Patient>();
        public List<Patient> GetAllPatientBLL()
        {
            PatientDAL patientDAL = new PatientDAL();
            return patientDAL.GetAllPatientsDAL();
        }
        public bool PatientLogin(string patientEmail, string patientPassword)
        {
            PatientDAL patientDAL = new PatientDAL();
            List<Patient> patients = patientDAL.GetAllPatientsDAL();
            bool flag = false;
            foreach (var item in patients)
            {
                if (item.PatientEmail == patientEmail && item.PatientPassword == patientPassword)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public string AddPatientBLL(Patient patient)
        {
            PatientDAL patientDAL = new PatientDAL();
            return patientDAL.AddPatientsDAL(patient);

        }
        public bool RemovePatientBLL(int patientId)
        {
            PatientDAL patientDAL = new PatientDAL();

            return patientDAL.RemovePatientsDAL(patientId);
        }
        public bool UpdatePatientBLL(Patient patient)
        {
            PatientDAL patientDAL = new PatientDAL();

            return patientDAL.UpdatePatientsDAL(patient);
        }
    }
}
