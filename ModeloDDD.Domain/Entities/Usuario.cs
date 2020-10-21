using Flunt.Validations;
using ModeloDDD.Domain.Contracts.Services;
using ModeloDDD.Domain.ValueObjects;
using ModeloDDD.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ModeloDDD.Domain.Entities
{
    public class Usuario : Entity
    {
        public Usuario()
        {

        }
        public Usuario(string nome, string email, string password)
        {
            Nome = nome;
            Email  = email;
            Password = password;

            AddNotifications(new Contract()
                .Requires()
                .IsEmail(Email,"Email","E-mail inválido")
                .HasMaxLen(Nome,300,"Nome","O nome pode ter no máximo 300 caracteres")
                .HasMinLen(Nome,3,"Nome","O nome deve ter pelo menos 3 caracteres")
                );
            
            if (!IsValidPassword())
            {
                AddNotification("Password", "A senha deve possuir 8 caracteres, com letras maiusculas e minusculas, um número e um caracter especial");
            }
        }

        public int UsuarioId { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Role { get; set; }

        public void HidePassword()
        {
            Password = "";
        }
        public bool IsValidPassword()
        {
            return Regex.IsMatch(Password, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,15}$");
        }
    }
}
