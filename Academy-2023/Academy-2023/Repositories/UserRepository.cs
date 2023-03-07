using Academy_2023.Data;

namespace Academy_2023.Repositories
{
    public class UserRepository
    {
        public static List<User> Users = new List<User>();
        public IEnumerable<User> GetAll()
        {
            return Users;
        }

    }
}
