using ModeloDDD.Domain.Contracts.Services;
using ModeloDDD.Domain.Entities;
using ModeloDDD.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloDDD.Business.Services
{
    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepository _repository;
        public UsuarioService(IUsuarioRepository repository)
        {
            _repository = repository;
        }

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
            _repository.Dispose();
        }

        public Usuario GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Usuario Register(string name, string email, string password, string confirmPassword)
        {
            Usuario u = new Usuario(name, email, password);
            _repository.Create(u);
            return u;


        }

        public string ResetPassword(string email)
        {
            throw new NotImplementedException();
        }
    }
}
