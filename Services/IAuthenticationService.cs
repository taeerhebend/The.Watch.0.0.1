using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheWatch.Models;

namespace TheWatch.Services
{
    public interface IAuthenticationService 
    {
        Task<User> SignInAsync(string username, string password);
        Task SignOutAsync();
        Task<User> RegisterAsync(string username, string password);
        Task<bool> ChangePasswordAsync(string username, string oldPassword, string newPassword);
        Task<bool> ForgotPasswordAsync(string username);
        Task<bool> ResetPasswordAsync(string username, string code, string newPassword);
    }

    public class AuthenticationService : IAuthenticationService
    {
        public Task<bool> ChangePasswordAsync(string username, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ForgotPasswordAsync(string username)
        {
            throw new NotImplementedException();
        }

        public Task<User> RegisterAsync(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ResetPasswordAsync(string username, string code, string newPassword)
        {
            throw new NotImplementedException();
        }

        public Task<User> SignInAsync(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task SignOutAsync()
        {
            throw new NotImplementedException();
        }
    }
}
