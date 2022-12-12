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
        async Task<List<Event>> SelectEvents()
        {
            throw new NotImplementedException();
        }
        async Task InsertReservation(RecervedPlase plase)
        {
            throw new NotImplementedException();
        }
        async Task<List<RecervedPlase>> SelectReservation()
        {
            throw new NotImplementedException();
        }
    }
}
