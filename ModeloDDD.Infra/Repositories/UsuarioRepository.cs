using ModeloDDD.Domain.Entities;
using ModeloDDD.Domain.Repositories;
using ModeloDDD.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDDD.Infra.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DataContext _context;

        public UsuarioRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Usuario> Create(Usuario user)
        {
            _context.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public void Delete(Usuario user)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IEnumerable<Usuario> Get(string email)
        {
            return _context.Usuario.Where(e => e.Email == email);
        }

        public Usuario Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Usuario user)
        {
            throw new NotImplementedException();
        }
    }
}
