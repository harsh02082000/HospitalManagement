using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_Management_Entity;

namespace Hospital_Management_Data
{
    public class AdminDAL
    {
        public List<Admin> admins = new List<Admin>();

        Admin adminsObj1 = new Admin(1, "Harshjeet", "harsh@gmail.com", "abc");
        Admin adminsObj2 = new Admin(2, "Mihir kumar", "mihir@gmail.com", "Mihir");

        public List<Admin> GetAllAdminsDAL()
        {
            admins.Add(adminsObj1);
            admins.Add(adminsObj2);

            return admins;
        }
    }
}
