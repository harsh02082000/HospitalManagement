using Hospital_Management_Bussiness;
using Hospital_Management_Data;
using Hospital_Management_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_Presentation
{
    public class PatientPL
    {
        Patient patient = null;
        public void PatientLogin()
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Patient-Login-----------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Email Id: ");
            string patientEmail = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Password: ");
            string patientPass = Console.ReadLine();
            PatientBLL patientBLL = new PatientBLL();
            bool status = patientBLL.PatientLogin(patientEmail, patientPass);
            if (status)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Logged in successfully...");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid credentials");
            }
            GetPatientMenu();


        }
       
        public void GetPatientMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Welcome-to-Patient-Section--------------\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("1) Press 1 to add a Patient \n");
            Console.Write("2) Press 2 to update a Patient \n");
            Console.Write("3) Press 3 to delete a Patient\n");
            Console.Write("4) Press 4 to show all Patient \n");
            Console.Write("5) Press 5 to exit \n");
            int bk = Convert.ToInt32(Console.ReadLine());
            switch (bk)
            {
                case 1:
                    AddPatient();
                    break;
                case 2:
                    UpdatePatient();
                    break;
                case 3:
                    RemovePatient();
                    break;
                case 4:
                    GetAllPatient();
                    break;
                case 5:
                    break;
            }
            Console.Read();
        }
        public void AddPatient()
        {
            patient = new Patient();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Patient Details...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Patient Id: ");
            patient.PatientId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Patient Name: ");
            patient.PatientName = Console.ReadLine();
            Console.Write("Patient Email: ");
            patient.PatientEmail = Console.ReadLine();
            Console.Write("Patient Password: ");
            patient.PatientPassword = Console.ReadLine();

            PatientBLL patientBLL = new PatientBLL();
            string msg = patientBLL.AddPatientBLL(patient);
            GetPatientMenu();

        }
        public void RemovePatient()
        {
            PatientBLL patientBLL = new PatientBLL();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Patient Details...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Patient Id: ");
            int PatientId = Convert.ToInt32(Console.ReadLine());
            bool flag = patientBLL.RemovePatientBLL(PatientId);
            if (flag == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Patient deleted successfully...");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("sorry! You need to Delete again");
            }
            GetPatientMenu();
        }
        public void UpdatePatient()
        {
            Console.WriteLine("Enter Patient details", Console.ForegroundColor = ConsoleColor.DarkCyan);
            Console.Write("Patient Id: ", Console.ForegroundColor = ConsoleColor.White);
            int patientId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Patient Name: ");
            string patientName = Console.ReadLine();
            Console.Write("Patient Email:");
            string patientEmail = Console.ReadLine();
            Console.Write("Patient Password:");
            string patientPassword = Console.ReadLine();
            PatientBLL patientBLL = new PatientBLL();
            Patient patient = new Patient(patientId, patientName, patientEmail, patientPassword);
            bool flag = patientBLL.UpdatePatientBLL(patient);
            if (flag == true)
            {
                Console.WriteLine("Update Successfully...", Console.ForegroundColor = ConsoleColor.Green);
                GetPatientMenu();
            }
            else
            {
                Console.WriteLine("sorry ! You need to update again", Console.ForegroundColor = ConsoleColor.Red);
            }
            GetPatientMenu();

        }
        public void GetAllPatient()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------------------------Patient-List-------------------------");
            Console.WriteLine("--Id----Name----------Email-------------------Password--------");
            Console.ForegroundColor = ConsoleColor.White;
            PatientBLL patientBLL = new PatientBLL();
            List<Patient> patientBLLList = new List<Patient>();
            patientBLLList = patientBLL.GetAllPatientBLL();
            foreach (var item in patientBLLList)
            {
                Console.WriteLine(item.PatientId + "\t" + item.PatientName + "\t \t" + item.PatientEmail + "\t \t" + item.PatientPassword);



            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            GetPatientMenu();
        }
    }
}
