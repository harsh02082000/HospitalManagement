using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_Management_Presentation;

namespace Hospital_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to Hospital Management System");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1) Press 1 to login as Admin\n" +
            "2) Press 2 to login as Doctor\n" +
            "3) Press 3 to login as Patient\n"+
            "4) Press 4 to exit");

            int logCase = int.Parse(Console.ReadLine());
            switch (logCase)
            {
                case 1:
                    AdminPL adminPL = new AdminPL();
                    adminPL.AdminLogin();


                    break;
                case 2:
                   DoctorPL doctorPL = new DoctorPL();
                   doctorPL.DoctorLogin();
                  break;
                case 3:
                    PatientPL patientPL = new PatientPL();
                    patientPL.PatientLogin();   
                    break;
                case 4:
                    break;

            }
            Console.Read();
        }
    }
}
