using Core.Entities.Admin;
using Core.Interfaces;
using Core.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class AuthService : IAuthService<User>
    {
        private readonly IAsyncRepository<User> _userRepository;

        public AuthService(IAsyncRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> UserExists(string username)
        {
            var userSpec = new UserSpecification(username);
            try
            {
                var data = await _userRepository.ListAllAsync();
                if (await _userRepository.FirstOrDefaultAsync(userSpec) != null)
                    return true;
            }
            catch (Exception ex)
            {

                throw;
            }
           

            return false;
        }

        public async Task<bool> Update(User user, string password, string newPassword = null)
        {

            if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
                return false;

            if (newPassword != null)
            {
                CreatePasswordHash(newPassword, out var passwordHash, out var passwordSalt);
                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;
            }

            try
            {
                await _userRepository.UpdateAsync(user);
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public async Task<bool> ResetPassword(User user, string password)
        {
            if (password != null)
            {
                CreatePasswordHash(password, out var passwordHash, out var passwordSalt);
                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;
            }
            try
            {
                await _userRepository.UpdateAsync(user);
                return true;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<User> Login(string username, string password)
        {
            var userSpec = new UserSpecification(username);
            User user = await _userRepository.FirstOrDefaultAsync(userSpec);
            if (user == null)
                return null;
            if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
                return null;
            return user;
        }

        public async Task<bool> Create(User user, string password)
        {

            try
            {
                if (!string.IsNullOrEmpty(password))
                {
                    CreatePasswordHash(password, out var passwordHash, out var passwordSalt);
                    user.PasswordHash = passwordHash;
                    user.PasswordSalt = passwordSalt;
                }
                await _userRepository.AddAsync(user);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }



        internal bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i]) return false;
                }
                return true;
            }
        }

        internal void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
