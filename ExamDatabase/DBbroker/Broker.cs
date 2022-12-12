using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDatabase.DBbroker
{
    public partial class Broker : IBroker
    {
        public string GetConnectionString()
        {
            return @"Server=SHOHRUZBEK; Database=EventManagement;";
        }
    }
}
