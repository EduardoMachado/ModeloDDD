using ModeloDDD.Domain.Contracts.Services;
using ModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloDDD.Business.Services
{
    public class UsuarioService : IUsuarioService
    {
        public Usuario Authenticate(string email, string password)
        {
            throw new NotImplementedException();
        }

        public void ChangeInformation(string email, string name)
        {
            throw new NotImplementedException();
        }

        public void ChangePassword(string email, string password, string newPassword, string confirmNewPassword)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Usuario GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public void Register(string name, string email, string password, string confirmPassword)
        {
            throw new NotImplementedException();
        }

        public string ResetPassword(string email)
        {
            throw new NotImplementedException();
        }
    }
}
