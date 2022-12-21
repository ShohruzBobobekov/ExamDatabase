namespace ExamDatabase.Model
{
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }

    public enum Role
    {
        Admin,
        Company,
        User
    }
}
