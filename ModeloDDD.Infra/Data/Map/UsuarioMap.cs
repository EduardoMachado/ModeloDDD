using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloDDD.Infra.Data.Map
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(e => e.UsuarioId);
            builder.Property(e => e.Nome).HasMaxLength(300);
            builder.HasIndex(e => e.Email).IsUnique();
        }
    }
}
