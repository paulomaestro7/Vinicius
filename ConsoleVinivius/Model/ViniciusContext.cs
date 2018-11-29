using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConsoleVinivius.Model
{
    public partial class ViniciusContext : DbContext
    {
        public ViniciusContext()
        {
        }

        public ViniciusContext(DbContextOptions<ViniciusContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tablogin> Tablogin { get; set; }
        public virtual DbSet<Tablog> Tablog { get; set; }
        public virtual DbSet<TabCasa> TabCasa { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=empvw02250\\dev;Initial Catalog=Vinicius;Persist Security Info=True;User ID=paulomaestro; Password=Et3c@2018+");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tablogin>(entity =>
            {
                entity.ToTable("tablogin");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .HasColumnName("senha")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Situacao)
                    .HasColumnName("situacao")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasColumnName("usuario")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tablog>(entity =>
            {
                entity.ToTable("tablog");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TabCasa>(entity =>
            {
                entity.ToTable("tabCasa");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Numero)
                .HasColumnName("numero");
            });
        }
    }
}
