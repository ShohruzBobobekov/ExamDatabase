using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDatabase.Model
{
    public class RecervedPlase
    {
        public int EventId { get; set; }
        public int PlaseX { get; set; }
        public int PlaseY { get; set; }
        public int UserId { get;set; }

        public RecervedPlase(int eventId, int plaseX, int plaseY, int userId)
        {
            EventId = eventId;
            PlaseX = plaseX;
            PlaseY = plaseY;
            UserId = userId;
        }
    }
}
