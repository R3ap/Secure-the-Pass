using Password_Manager_.NET_6.Model;

namespace Services_Core.Services.UserService
{
    public interface IUserServices
    {
        bool CheckUser(string email);
        bool InsertUser(User user);
        bool RemoveUser(User user, IList<Account> accounts);
        IList<User> SelectUsers();
        void UpdateUser(string password, string email);
    }
}
