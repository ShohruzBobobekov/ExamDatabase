namespace ExamDatabase.Model
{
    public class Room
    {
        public Guid Id { get; set; }
        public int RoomNumber { get; set; }
        public string RoomName { get; set; }
        public int PlaceNumber { get; set; }
        public ICollection<Event> Events { get; set; }
        public Room(Guid id, int roomNumber, string roomName, int placeNumber)
        {
            Id = id;
            RoomNumber = roomNumber;
            RoomName = roomName;
            PlaceNumber = placeNumber;
        }
    }
}
