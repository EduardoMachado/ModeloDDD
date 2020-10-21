using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
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

        public async Task<Usuario> Authenticate(string email, string password)
        {
            var user = await GetByEmail(email);
            if (user.Any())
            {
                var usuario = user.First();
                if (usuario.Password == password)
                {
                    return usuario;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
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

        public async Task<IEnumerable<Usuario>> GetByEmail(string email)
        {
            return  _repository.Get(email);
        }

        public async Task<Usuario> Register(Usuario usuario)
        {
            var user = await GetByEmail(usuario.Email);
            if (user.Any())
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
