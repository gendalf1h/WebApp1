using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using WebApp1.Models;
using WebApp1.Repository;

namespace WebApp1.Service
{
    public class AuthService
    {
        private readonly IUserRepository _repo;

        public AuthService (IUserRepository repo)
        {
            _repo = repo;
        }

        public async Task<bool> Register(string email, string password)
        {
            var existingUser = await _repo.GetByEmailAsync(email);

            if (existingUser != null)
            {
                return false;
            }

            var user = new User
            {
                Email = email,
                PasswordHash = Hash(password)
            };

            await _repo.AddAsync(user);

            return true;
        }

        private string Hash(string input)
        {
            using var sha256 = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(input);
            var hash = sha256.ComputeHash(bytes);

            return Convert.ToBase64String(hash);
        }

        public async Task<User?> Login(string email, string password)
        {
            var user = await _repo.GetByEmailAsync(email);

            if(user == null) 
            {
                return null;
            }

            var hash = Hash(password);

            if (user.PasswordHash != hash)
            {
                return null;
            }
            return user;

        }




    }
}
