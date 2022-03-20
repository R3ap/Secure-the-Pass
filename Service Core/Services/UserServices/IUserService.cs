using Password_Manager_Services_Core.Model;

namespace Password_Manager_Services_Core.Services.UserServices
{
    public interface IUserService
    {
        bool CheckUser(string email);
        bool InsertUser(User user);
        bool RemoveUser(User user, IList<Account> accounts);
        IList<User> SelectUsers();
        void UpdateUser(string password, string email);
    }
}
