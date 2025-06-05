using Trans_system.Domain.Entities;

namespace Trans_system.Domain.Interfaces;
public interface IUserRepository
{
    public User RegisterUser(User user);
    public User UpdateUser(User user);
    public List<User> GetAllUsers();
    public User Login(User user);
    public User DeleteUser(User user);
}
