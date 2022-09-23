using Hospital_Management_Bussiness;
using Hospital_Management_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_Presentation
{
    public class DoctorPL
    {
        public void DoctorLogin()
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Doctor-Login-----------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Email Id: ");
            string doctorEmail = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Password: ");
            string doctorPass = Console.ReadLine();
            DoctorBLL doctorBLL = new DoctorBLL();
            bool status = doctorBLL.DoctorLogin(doctorEmail, doctorPass);
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
            GetDoctorMenu();


        }
        Doctor doctor = null;
        public void GetDoctorMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Welcome-to-doctor-Section--------------\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("1) Press 1 to add a Doctor \n");
            Console.Write("2) Press 2 to update a Doctor \n");
            Console.Write("3) Press 3 to delete a Doctor \n");
            Console.Write("4) Press 4 to show all Doctor \n");
            Console.Write("5) Press 5 to exit \n");
            int bk = Convert.ToInt32(Console.ReadLine());
            switch (bk)
            {
                case 1:
                    AddDoctor();
                    break;
                case 2:
                    UpdateDoctor();
                    break;
                case 3:
                    RemoveDoctor();
                    break;
                case 4:
                    GetAllDoctor();
                    break;
                case 5:
                    break;
            }
            Console.Read();
        }
        public void AddDoctor()
        {
            doctor = new Doctor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Doctor Details...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Doctor Id: ");
            doctor.DoctorId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Doctor Name: ");
            doctor.DoctorName = Console.ReadLine();
            Console.Write("Doctor Email: ");
            doctor.DoctorEmail = Console.ReadLine();
            Console.Write("Doctor Password: ");
            doctor.DoctorPassword = Console.ReadLine();

            DoctorBLL doctorBLL = new DoctorBLL();
            string msg = doctorBLL.AddDoctorBLL(doctor);
            GetDoctorMenu();

        }
        public void RemoveDoctor()
        {
            DoctorBLL doctorBLL = new DoctorBLL();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Doctor Details...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Doctor Id: ");
            int DoctorId = Convert.ToInt32(Console.ReadLine());
            bool flag = doctorBLL.RemoveDoctorBLL(DoctorId);
            if (flag == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Doctor deleted successfully...");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("sorry! You need to Delete again");
            }
            GetDoctorMenu();
        }
        public void UpdateDoctor()
        {
            Console.WriteLine("Enter Doctor details", Console.ForegroundColor = ConsoleColor.DarkCyan);
            Console.Write("Doctor Id: ", Console.ForegroundColor = ConsoleColor.White);
            int doctorId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Doctor Name: ");
            string doctorName = Console.ReadLine();
            Console.Write("Doctor Email:");
            string doctorEmail = Console.ReadLine();
            Console.Write("Doctor Password:");
            string doctorPassword = Console.ReadLine();
            DoctorBLL doctorBLL = new DoctorBLL();
            Doctor doctor = new Doctor(doctorId, doctorName, doctorEmail, doctorPassword);
            bool flag = doctorBLL.UpdateDoctorBLL(doctor);
            if (flag == true)
            {
                Console.WriteLine("Update Successfully...", Console.ForegroundColor = ConsoleColor.Green);
                GetDoctorMenu();
            }
            else
            {
                Console.WriteLine("sorry ! You need to update again", Console.ForegroundColor = ConsoleColor.Red);
            }
            GetDoctorMenu();

        }
        public void GetAllDoctor()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------------------------Doctor-List-------------------------");
            Console.WriteLine("--Id----Name----------Email-------------------Password--------");
            Console.ForegroundColor = ConsoleColor.White;
            DoctorBLL doctorBLL = new DoctorBLL();
            List<Doctor> doctorBLLList = new List<Doctor>();
            doctorBLLList = doctorBLL.GetAllDoctorBLL();
            foreach (var item in doctorBLLList)
            {
                Console.WriteLine(item.DoctorId + "\t" + item.DoctorName + "\t \t" + item.DoctorEmail + "\t \t" + item.DoctorPassword);



            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            GetDoctorMenu();
        }
    }
}
