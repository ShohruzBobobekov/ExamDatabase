using ExamDatabase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDatabase.DBbroker
{
    public partial class Broker : IBroker
    {
        async Task<List<Room>> SelectEmptyRooms(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }
        async Task InsertEvent(DateTime start, DateTime end, int roomId)
        {
            throw new NotImplementedException();
        }
        async Task<List<RecervedPlase>> SelectReservationCompany()
        {
            throw new NotImplementedException();
        }
    }
}
