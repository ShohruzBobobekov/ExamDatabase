using ExamDatabase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDatabase.DBbroker
{
    public partial interface IBroker
    {
        Task<List<Event>> SelectEvents();
        Task InsertReservation(RecervedPlase plase);
        Task<List<RecervedPlase>> SelectReservation();
    }
}
