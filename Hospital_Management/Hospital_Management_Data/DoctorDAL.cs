using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_Management_Entity;

namespace Hospital_Management_Data
{
    public class DoctorDAL
    {
        public static string sqlcon = "Data Source=VDC01LTC2159;Initial Catalog=HospitalManagement;Integrated Security=True;";
        public List<Doctor> doctors = new List<Doctor>();
        public List<Doctor> GetAllDoctorsDAL()
        {
            SqlConnection con = new SqlConnection(sqlcon);
            SqlDataAdapter adp = new SqlDataAdapter("select * from TblDoctor", con);
            DataTable dt = new DataTable();
            List<Doctor> doctors = new List<Doctor>();
            adp.Fill(dt);
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    doctors.Add(new Doctor
                    {
                        DoctorId = Convert.ToInt32(dt.Rows[i]["DoctorId"]),
                        DoctorName = dt.Rows[i]["DoctorName"].ToString(),
                        DoctorEmail = dt.Rows[i]["DoctorEmail"].ToString(),
                        DoctorPassword = dt.Rows[i]["DoctorPassword"].ToString()

                    });
                }
            }
          
            return doctors;
           
        }
        public string AddDoctorsDAL(Doctor doctor)
        {
           
            //#region disconnected approach
            var msg = "";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlDataAdapter adp = new SqlDataAdapter("insert into TblDoctor values(" + doctor.DoctorId + ",'" + doctor.DoctorName + "','" + doctor.DoctorEmail + "','" + doctor.DoctorPassword + "')", con);
            DataTable dt = new DataTable();
           
            adp.Fill(dt);

            msg = "Inserted";
          

            return msg;
           

        }

        public bool RemoveDoctorsDAL(int doctorId)
        {
            SqlConnection conn = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("delete from TblDoctor where DoctorId=" + doctorId, conn);
            conn.Open();
            var row = cmd.ExecuteNonQuery();
            conn.Close();
            return true;
        }
        public bool UpdateDoctorsDAL(Doctor doctor)
        {
            SqlConnection conn = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("update TblDoctor set DoctorEmail='" + doctor.DoctorEmail + "',DoctorPassword='" + doctor.DoctorPassword + "',DoctorId=" + doctor.DoctorId + ",DoctorName='" + doctor.DoctorName + "'where DoctorId=" + doctor.DoctorId, conn);
            conn.Open();
            var row = cmd.ExecuteNonQuery();
            conn.Close();
            return true;
        }
    }
}
