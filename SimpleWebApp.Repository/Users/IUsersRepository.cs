namespace SimpleWebApp.Repository.Users
{
    public interface IUsersRepository
    {
        void CreateUser(string login, string password, string email, UserRole roles);
        User GetUser(string email);
        void UpdateUser(string login, string email, UserRole role);
        void DeleteUser(string email);
    }

    public enum UserRole
    {
        User,
        Admin
    }
}