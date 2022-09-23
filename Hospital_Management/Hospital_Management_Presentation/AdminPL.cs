using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_Management_Bussiness;

namespace Hospital_Management_Presentation
{
    public class AdminPL
    {
        public void AdminLogin()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Admin-Login-----------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Email Id: ");
            string adminEmail = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Password: ");
            string adminPass = Console.ReadLine();
            AdminBLL adminBLL = new AdminBLL();
            bool status = adminBLL.AdminLogin(adminEmail, adminPass);
            if (status)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Logged in Successfully...");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid credentials");
            }
            SubMenu();


        }
        public void SubMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome-to-Admin-Section-------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1) Press 1 to show Doctor section");
            Console.WriteLine("2) Press 2 to show Patient section");
            Console.WriteLine("3) Press 3 to show Bill section");
            Console.WriteLine("4) Press 4 to show Appointment section");
            Console.WriteLine("5) Press 5 to show Room section");
            Console.WriteLine("6) Press 6 to show Prescription section");
            Console.Write("7) Press 7 to ");
            Console.WriteLine("logout", Console.ForegroundColor = ConsoleColor.Red);
            Console.ForegroundColor = ConsoleColor.White;
            int menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    DoctorPL doctorPL = new DoctorPL();
                    doctorPL.GetDoctorMenu();
                    break;
                case 2:
                    PatientPL patientPL = new PatientPL();
                    patientPL.GetPatientMenu();
                    break;
                case 3:
                    Console.ReadLine();
                    break;



            }
        }
    }
}
