namespace user_mcp.Models
{
    public class User
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public User(string id, string userName, string email, string address)
        {
            Id = id;
            UserName = userName;
            Email = email;
            Address = address;
        }
    }
}
