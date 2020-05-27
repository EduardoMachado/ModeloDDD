using ModeloDDD.Domain.Entities;
using System;

namespace ModeloDDD.Domain.Repositories
{
    public interface IUsuarioRepository : IDisposable
    {
        Usuario Get(string email);
        Usuario Get(Guid id);
        void Create(Usuario user);
        void Update(Usuario user);
        void Delete(Usuario user);
    }
}
