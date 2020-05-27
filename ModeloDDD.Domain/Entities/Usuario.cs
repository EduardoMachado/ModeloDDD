using Flunt.Validations;
using ModeloDDD.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloDDD.Domain.Entities
{
    public class Usuario : Entity
    {
        public Usuario(int usuarioId, string nome, string email, string password)
        {
            UsuarioId = usuarioId;
            Nome = nome;
            Email = email;
            Password = password;

            AddNotifications(new Contract()
                .Requires()
                .IsEmail(Email,"Email","E-mail inválido")
                .HasMaxLen(Nome,300,"Nome","O nome pode ter no máximo 300 caracteres")
                .HasMinLen(Nome,3,"Nome","O nome deve ter pelo menos 3 caracteres")
                );
        }

        public int UsuarioId { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }


    }
}
