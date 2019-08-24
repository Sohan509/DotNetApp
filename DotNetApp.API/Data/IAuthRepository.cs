using System.Threading.Tasks;
using DotNetApp.API.Models;

namespace DotNetApp.API.Data
{
    public interface IAuthRepository
    {
         Task<User> register(User user, string password);
         Task<User> Login(string username, string password);
         Task<bool> UserExits(string username);
    }
}