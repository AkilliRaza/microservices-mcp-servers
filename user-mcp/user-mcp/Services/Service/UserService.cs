using user_mcp.Services.Interfaces;

namespace user_mcp.Services.Service
{
    public class UserService : IUserService
    {
        private readonly Dictionary<string, User> _users;

        public UserService()
        {
            _users = new Dictionary<string, User>
            {
                ["user1"] = new User("user1", "Ali", "ali@gmail.com", "Lahore"),
                ["user2"] = new User("user2", "Sara", "sara@example.com", "Karachi"),
                ["user3"] = new User("user3", "Ahmed", "ahmed@example.com", "Islamabad"),
                ["user4"] = new User("user4", "Fatima", "fatima@example.com", "Quetta"),
                ["user5"] = new User("user5", "Bilal", "bilal@example.com", "Peshawar")
            };
        }

        public Task<List<User>> GetByIdAsync(string Id)
        {
            var result = _users.Values.Where(u => u.Id == Id).ToList();
            return Task.FromResult(result);
        }
    }
}
