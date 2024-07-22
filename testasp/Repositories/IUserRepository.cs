namespace testasp.Repositories
{
    public interface IUserRepository
    {
        Task<bool> Authenticate(string username, string password);
        Task<List<string>> GetUserNames();
    }
}