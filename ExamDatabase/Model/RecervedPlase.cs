namespace ExamDatabase.Model
{
    public class RecervedPlase
    {
        public Guid EventId { get; set; }
        public int PlaseX { get; set; }
        public int PlaseY { get; set; }
        public Guid UserId { get;set; }
        public User User { get; set; }
        public RecervedPlase(Guid eventId, Guid userId, int plaseX, int plaseY)
        {
            EventId = eventId;
            PlaseX = plaseX;
            PlaseY = plaseY;
            UserId = userId;
        }
    }
}
