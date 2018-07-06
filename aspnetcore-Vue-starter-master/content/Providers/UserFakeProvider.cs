
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vue2Spa.Models;

namespace Vue2Spa.Providers
{
    public class UserFakeProvider : IUser
    {
        private readonly List<User> _context;

        public UserFakeProvider()
        {
            _context = new List<User>();
            Initialize();
        }

        private void Initialize()
        {
            _context.Add(new User()
            {
                Name = "Guillaume D'Amour",
                Password = "123Password",
                Address = "123 Random Street, ssm",
                Email = "Random@gmail.com",
                IdentityId = "admin"
            });
            _context.Add(new User()
            {
                Name = "Max Vers",
                Password = "123Race",
                Address = "123 Fast Ave, ssm",
                Email = "f1@gmail.com",
                IdentityId = "User"
            });
        }

        public Task<IEnumerable<User>> GetUsers()
        {
            return Task.FromResult(_context.AsEnumerable());
        }
    }
}
