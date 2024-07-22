using testasp.Models;

namespace testasp.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> _users = new List<User>
        {
            new User 
            {
                Id = 1, Username = "admin", Password = "password"
            }
            // ... more users
        };

        public async Task<bool> Authenticate(string username, string password)
        {
            if (await Task.FromResult(_users.SingleOrDefault(x => x.Username == username && x.Password == password)) != null)
            {
                return true;
            }
            return false;
        }

        public async Task<List<string>> GetUserNames()
        {
            List<string> users = new List<string>();
            foreach (var user in _users)
            {
                users.Add(user.Username);
            }
            return await Task.FromResult(users);
        }
    }
}