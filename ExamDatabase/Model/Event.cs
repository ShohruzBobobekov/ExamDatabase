namespace ExamDatabase.Model
{
    public class Event
    {
        public Guid Id { get; set; }
        public string EventName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Guid RoomId { get; set; }
        public bool Status { get; set; }
    }
}
