using ElevateProjectFinal.Models;

namespace ElevateProjectFinal.Services
{
    public interface IUserService
    {
        void Create(User user);
        void Update(User user);
        void Delete(int id);
        User Read(int id);
        List<User> ReadAll();
    }
}
