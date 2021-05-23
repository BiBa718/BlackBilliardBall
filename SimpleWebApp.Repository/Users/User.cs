namespace SimpleWebApp.Repository.Users
{
    public class User
    {
        string Login { get; set; }
        string Password { get; set; }
        string Email { get; set; }
        UserRole Role { get; set; }
    }
}