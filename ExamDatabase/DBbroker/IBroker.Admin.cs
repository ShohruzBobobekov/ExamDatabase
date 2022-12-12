using ExamDatabase.Model;


namespace ExamDatabase.DBbroker
{
    public partial interface IBroker
    {
        Task InsertRoom(Room room);
        Task<List<Room>> SelectAllRooms();
        Task DeleteRoom(Room room);
        Task UpdateRomm(Room room);

    }
}
