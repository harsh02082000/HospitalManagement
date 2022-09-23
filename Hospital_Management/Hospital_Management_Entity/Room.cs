using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_Entity
{
    public class Room
    {
        public int RoomNo { get; set; }
        public int PatientId { get; set; }
        public Room(int roomNo, int patientId)
        {
            RoomNo = roomNo;
            PatientId = patientId;
        }
        public Room()
        {

        }
    }
}
