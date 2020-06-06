using ModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ModeloDDD.Domain.Repositories
{
    public interface IUsuarioRepository : IDisposable
    {
        IEnumerable<Usuario> Get(string email);
        Usuario Get(Guid id);
        Task<Usuario> Create(Usuario user);
        void Update(Usuario user);
        void Delete(Usuario user);
    }
}
