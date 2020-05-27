using ModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloDDD.Domain.Contracts.Services
{
    public interface IUsuarioService : IDisposable
    {
        Usuario Authenticate(string email, string password);
        Usuario GetByEmail(string email);
        void Register(string name, string email, string password, string confirmPassword);
        void ChangeInformation(string email, string name);
        void ChangePassword(string email, string password, string newPassword, string confirmNewPassword);
        string ResetPassword(string email);
    }
}
