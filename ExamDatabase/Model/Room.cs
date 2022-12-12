using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDatabase.Model
{
    public class Room
    {
        public int Id { get; set; }
        public int RoomNumber { get; set; }
        public string RoomName { get; set; }
        public int PlaceNumber { get; set; }

        public Room(int id, int roomNumber, string roomName, int placeNumber)
        {
            Id = id;
            RoomNumber = roomNumber;
            RoomName = roomName;
            PlaceNumber = placeNumber;
        }
    }
}
