using ExamDatabase.Model;
using System.Data.SqlClient;

namespace ExamDatabase.DBbroker
{
    public partial class Broker : IBroker
    {
        async Task InsertRoom(Room room)
        {
            using SqlConnection connect = new SqlConnection(GetConnectionString());
            using SqlCommand cmd = new SqlCommand("InsertRoom", connect);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            await connect.OpenAsync();
            cmd.Parameters.AddWithValue("@RoomNumber", room.RoomNumber);
            cmd.Parameters.AddWithValue("@RoomName", room.RoomName);
            cmd.Parameters.AddWithValue("@PlaceNumber", room.PlaceNumber);
            cmd.ExecuteNonQuery();
        }
        async Task<List<Room>> SelectAllRooms()
        {
            using SqlConnection connect = new SqlConnection(GetConnectionString());
            using SqlCommand cmd = new SqlCommand("SelectAllRooms", connect);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            await connect.OpenAsync();
            SqlDataReader reader = cmd.ExecuteReader();

            List<Room> list = new List<Room>();
            while (reader.Read())
            {
                list.Add(new Room(
                    int.Parse(reader["Id"].ToString()),
                    int.Parse(reader["RoomNumber"].ToString()),
                    reader["RoomName"].ToString(),
                    int.Parse(reader["PlaceNumber"].ToString())
                ));
            }
            return list;
        }
      
        async Task DeleteRoom(Room room)
        {
            using SqlConnection connect = new SqlConnection(GetConnectionString());
            using SqlCommand cmd = new SqlCommand("DeleteRoom", connect);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            await connect.OpenAsync();
            cmd.Parameters.AddWithValue("@RoomId", room.Id);
            cmd.ExecuteNonQuery();

        }
        async Task UpdateRoom(Room room)
        {
            using SqlConnection connect = new SqlConnection(GetConnectionString());
            using SqlCommand cmd = new SqlCommand("UpdateRoom", connect);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            await connect.OpenAsync();
            cmd.Parameters.AddWithValue("@RoomId", room.Id);
            cmd.Parameters.AddWithValue("@RoomNumber", room.RoomNumber);
            cmd.Parameters.AddWithValue("@RoomName", room.RoomName);
            cmd.Parameters.AddWithValue("@PlaceNumber", room.PlaceNumber);
            cmd.ExecuteNonQuery();
        }
    }
}
