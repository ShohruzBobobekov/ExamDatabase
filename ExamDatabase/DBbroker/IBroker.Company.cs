﻿using ExamDatabase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDatabase.DBbroker
{
    public partial interface IBroker
    {
        Task<List<Room>> SelectEmptyRooms(DateTime start, DateTime end);
        Task InsertEvent(DateTime start,DateTime end,int roomId);
        Task<List<RecervedPlase>> SelectReservationCompany();


    }
}
