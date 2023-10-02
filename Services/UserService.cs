using ElevateProjectFinal.Models;

namespace ElevateProjectFinal.Services
{
    public class UserService : IUserService
    {
        private DatabaseContext dbContext;
        public UserService(DatabaseContext dbContext) {  this.dbContext = dbContext; }
        public void Create(User user)
        {
            dbContext.User.Add(user);
            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User Read(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> ReadAll()
        {
            throw new NotImplementedException();
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
