using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheWatch.Models.UserData;

namespace TheWatch.Services
{
    /// <summary>
    /// Interface for authentication service.
    /// </summary>
    public interface IAuthenticationService 
    {
        /// <summary>
        /// Signs in a user asynchronously.
        /// </summary>
        /// <param name="username">The username of the user.</param>
        /// <param name="password">The password of the user.</param>
        /// <returns>A task representing the asynchronous operation. Upon completion, returns a User object.</returns>
        Task<User> SignInAsync(string username, string password);

        /// <summary>
        /// Signs out the currently authenticated user.
        /// </summary>
        /// <returns>A task representing the asynchronous sign out operation.</returns>
        Task SignOutAsync();

        /// <summary>
        /// Register a new user with the given username and password.
        /// </summary>
        /// <param name="username">The username of the new user.</param>
        /// <param name="password">The password of the new user.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task<User> RegisterAsync(string username, string password);

        /// <summary>
        /// Changes the password of the user with the specified username.
        /// </summary>
        /// <param name="username">The username of the user.</param>
        /// <param name="oldPassword">The old password of the user.</param>
        /// <param name="newPassword">The new password to be set for the user.</param>
        /// <returns>A task representing the asynchronous operation. The task result will be true if the password was successfully changed; otherwise, false.</returns>
        Task<bool> ChangePasswordAsync(string username, string oldPassword, string newPassword);

        /// <summary>
        /// Sends a forgot password email to the user with the provided username.
        /// </summary>
        /// <param name="username">The username of the user to send the forgot password email to.</param>
        /// <returns>Returns a Task&lt;bool&gt; that represents the asynchronous operation. The task result contains true if the forgot password email was successfully sent; otherwise, false.</returns>
        Task<bool> ForgotPasswordAsync(string username);

        /// <summary>
        /// Resets the password for a user with the specified username.
        /// </summary>
        /// <param name="username">The username of the user.</param>
        /// <param name="code">The verification code.</param>
        /// <param name="newPassword">The new password to set.</param>
        /// <returns>A task representing the asynchronous operation. The task result contains a boolean value indicating whether the password was reset successfully.</returns>
        Task<bool> ResetPasswordAsync(string username, string code, string newPassword);
    }

    /// <summary>
    /// The AuthenticationService class is responsible for handling user authentication and authorization.
    /// </summary>
    public class AuthenticationService : IAuthenticationService
    {
        /// <summary>
        /// Changes the password for the specified user.
        /// </summary>
        /// <param name="username">The username of the user.</param>
        /// <param name="oldPassword">The current password of the user.</param>
        /// <param name="newPassword">The new password for the user.</param>
        /// <returns>
        /// A <see cref="Task{TResult}"/> representing the asynchronous operation.
        /// The task result is a boolean value indicating whether the password change was successful or not.
        /// </returns>
        public Task<bool> ChangePasswordAsync(string username, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sends a password reset email to the specified username.
        /// </summary>
        /// <param name="username">The username for which to send the password reset email.</param>
        /// <returns>Returns a boolean value indicating whether the password reset email was successfully sent or not.</returns>
        public Task<bool> ForgotPasswordAsync(string username)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Registers a new user with the specified username and password.
        /// </summary>
        /// <param name="username">The username of the user to be registered.</param>
        /// <param name="password">The password of the user to be registered.</param>
        /// <returns>A task representing the asynchronous operation. The task result contains the registered user.</returns>
        public Task<User> RegisterAsync(string username, string password)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Resets the password for a user.
        /// </summary>
        /// <param name="username">The username of the user.</param>
        /// <param name="code">The code received for password reset.</param>
        /// <param name="newPassword">The new password to set.</param>
        /// <returns>A boolean value indicating whether the password reset was successful or not.</returns>
        public Task<bool> ResetPasswordAsync(string username, string code, string newPassword)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Signs in a user with the given username and password.
        /// </summary>
        /// <param name="username">The username of the user.</param>
        /// <param name="password">The password of the user.</param>
        /// <returns>A Task object representing the asynchronous operation. The task result contains the signed-in user.</returns>
        public Task<User> SignInAsync(string username, string password)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Signs the user out.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public Task SignOutAsync()
        {
            throw new NotImplementedException();
        }
    }
}
