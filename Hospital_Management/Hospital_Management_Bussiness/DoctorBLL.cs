using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_Management_Data;
using Hospital_Management_Entity;

namespace Hospital_Management_Bussiness
{
    public class DoctorBLL
    {
        List<Doctor> dalDoctor = new List<Doctor>();
        public List<Doctor> GetAllDoctorBLL()
        {
            DoctorDAL doctorDAL = new DoctorDAL();
            return doctorDAL.GetAllDoctorsDAL();
        }
        
        public bool DoctorLogin(string doctorEmail, string doctorPassword)
        {
            DoctorDAL doctorDAL = new DoctorDAL();
            List<Doctor> doctors = doctorDAL.GetAllDoctorsDAL();
            bool flag = false;
            foreach (var item in doctors)
            {
                if (item.DoctorEmail == doctorEmail && item.DoctorPassword == doctorPassword)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public string AddDoctorBLL(Doctor doctor)
        {
            DoctorDAL doctorDAL = new DoctorDAL();
            return doctorDAL.AddDoctorsDAL(doctor);

        }
        public bool RemoveDoctorBLL(int doctorId)
        {
            DoctorDAL doctorDAL = new DoctorDAL();

            return doctorDAL.RemoveDoctorsDAL(doctorId);
        }
        public bool UpdateDoctorBLL(Doctor doctor)
        {
            DoctorDAL doctorDAL = new DoctorDAL();

            return doctorDAL.UpdateDoctorsDAL(doctor);
        }
    }
}
