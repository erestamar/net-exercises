using UserLoginOperation_Test.Models;

namespace UserLoginOperation_Test.Repo
{
    public interface IUserRepo
    {
        public void Create(User user);
        public void Update(User user);
        public void Delete(Guid userId);
        public List<User> GetAll();
        public User Get(Guid userId);

    }
}
