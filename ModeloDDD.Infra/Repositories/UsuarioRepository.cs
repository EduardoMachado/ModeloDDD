using ModeloDDD.Domain.Entities;
using ModeloDDD.Domain.Repositories;
using ModeloDDD.Infra.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloDDD.Infra.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DataContext _context;

        public UsuarioRepository(DataContext context)
        {
            _context = context;
        }

        public void Create(Usuario user)
        {
            _context.Add(user);
            _context.SaveChanges();
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
            throw new NotImplementedException();
        }

        public Usuario Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Usuario user)
        {
            throw new NotImplementedException();
        }

        Usuario IUsuarioRepository.Get(string email)
        {
            throw new NotImplementedException();
        }
    }
}
