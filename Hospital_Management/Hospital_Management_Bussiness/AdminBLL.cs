using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_Management_Entity;
using Hospital_Management_Data;

namespace Hospital_Management_Bussiness
{
    public class AdminBLL
    {
        public bool AdminLogin(string adminEmail, string adminPassword)
        {
            AdminDAL adminDAL = new AdminDAL();
            List<Admin> admins = adminDAL.GetAllAdminsDAL();
            bool flag = false;
            foreach (var item in admins)
            {
                if (item.AdminEmail == adminEmail && item.AdminPassword == adminPassword)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
    }
}
