using ModeloDDD.Domain.Contracts.Services;
using ModeloDDD.Domain.Entities;
using ModeloDDD.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public IEnumerable<Usuario> GetByEmail(string email)
        {
            return _repository.Get(email);
        }

        public async Task<Usuario> Register(Usuario usuario)
        {
            if (GetByEmail(usuario.Email).Any())
            {
                usuario.AddNotification("E-mail", "E-mail informado já está cadastrado.");
                return usuario;
            }
            else
            {
                return await _repository.Create(usuario);
            }
        }

        public string ResetPassword(string email)
        {
            throw new NotImplementedException();
        }
    }
}
