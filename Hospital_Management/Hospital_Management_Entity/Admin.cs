using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_Entity
{
    public class Admin
    {
        public string AdminEmail { get; set; }
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string AdminPassword { get; set; }

        public Admin(int adminId, string adminName, string adminEmail, string adminPassword)
        {
            this.AdminId = adminId;
            this.AdminName = adminName;
            this.AdminEmail = adminEmail;
            this.AdminPassword = adminPassword;
        }
    }
}
