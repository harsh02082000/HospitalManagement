using Hospital_Management_Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_Data
{
    public class PatientDAL
    {
        public static string sqlcon = "Data Source=VDC01LTC2159;Initial Catalog=HospitalManagement;Integrated Security=True;";
        public List<Patient> patients = new List<Patient>();
        public List<Patient> GetAllPatientsDAL()
        {
            SqlConnection con = new SqlConnection(sqlcon);
            SqlDataAdapter adp = new SqlDataAdapter("select * from TblPatient", con);
            DataTable dt = new DataTable();
            List<Patient> patients = new List<Patient>();
            adp.Fill(dt);
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    patients.Add(new Patient
                    {
                        PatientId = Convert.ToInt32(dt.Rows[i]["PatientId"]),
                        PatientName = dt.Rows[i]["PatientName"].ToString(),
                        PatientEmail = dt.Rows[i]["PatientEmail"].ToString(),
                        PatientPassword = dt.Rows[i]["PatientPassword"].ToString()

                    });
                }
            }

            return patients;

        }
        public string AddPatientsDAL(Patient patient)
        {

            //#region disconnected approach
            var msg = "";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlDataAdapter adp = new SqlDataAdapter("insert into TblPatient values(" + patient.PatientId + ",'" + patient.PatientName + "','" + patient.PatientEmail + "','" + patient.PatientPassword + "')", con);
            DataTable dt = new DataTable();

            adp.Fill(dt);

            msg = "Inserted";


            return msg;


        }

        public bool RemovePatientsDAL(int patientId)
        {
            SqlConnection conn = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("delete from TblPatient where PatientId=" + patientId, conn);
            conn.Open();
            var row = cmd.ExecuteNonQuery();
            conn.Close();
            return true;
        }
        public bool UpdatePatientsDAL(Patient patient)
        {
            SqlConnection conn = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("update TblPatient set PatientEmail='" + patient.PatientEmail + "',PatientPassword='" + patient.PatientPassword + "',PatientId='" + patient.PatientId + "',PatientName='" + patient.PatientName + "'where PatientId=" + patient.PatientId, conn);
            conn.Open();
            var row = cmd.ExecuteNonQuery();
            conn.Close();
            return true;
        }
    }
}
