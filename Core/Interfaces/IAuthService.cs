using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IAuthService<T>
    {
        Task<T> Login(string username, string password);
        Task<bool> UserExists(string username);
        Task<bool> Update(T user, string password, string newPassword = null);
        Task<bool> ResetPassword(T user, string password);
        Task<bool> Create(T user, string password);
    }
}
