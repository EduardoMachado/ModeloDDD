using ModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDDD.Domain.Contracts.Services
{
    public interface IUsuarioService : IDisposable
    {
        Task<Usuario> Authenticate(string email, string password);
        Task<IEnumerable<Usuario>> GetByEmail(string email);
        Task<Usuario> Register(Usuario user);
        void ChangeInformation(string email, string name);
        void ChangePassword(string email, string password, string newPassword, string confirmNewPassword);
        string ResetPassword(string email);
    }
}
