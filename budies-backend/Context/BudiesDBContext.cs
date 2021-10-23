using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using budies_backend.Models;

namespace budies_backend.Context
{
    public partial class BudiesDBContext : DbContext
    {
        public BudiesDBContext()
        {

        }

        public BudiesDBContext(DbContextOptions<BudiesDBContext> options) : base(options)
        {

        }

        public virtual DbSet<Strains> Strains { get; set; }
        public virtual DbSet<Effects> Effects { get; set; }
        public virtual DbSet<Ailments> Ailments { get; set; }
        public virtual DbSet<Flavors> Flavors { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Strains>(entity =>
            {
                entity.Property(model => model.Id).HasColumnName("id");
                entity.Property(model => model.Name).HasColumnName("name")
                    .HasMaxLength(50)
                    .IsRequired();
                entity.Property(model => model.Type).HasColumnName("type")
                    .HasMaxLength(15)
                    .IsRequired();
                entity.Property(model => model.Rating).HasColumnName("rating")
                    .HasMaxLength(5)
                    .IsRequired();
                entity.Property(model => model.Description).HasColumnName("description")
                    .HasMaxLength(600);

                entity.HasOne(s => s.Effect)
                    .WithMany(e => e.Strains)
                    .HasForeignKey(s => s.EffectsID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Strains_Effects");
                entity.HasOne(s => s.Ailments)
                    .WithMany(a => a.Strains)
                    .HasForeignKey(s => s.AilmentsID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Strains_Ailments");
                entity.HasOne(s => s.Flavors)
                    .WithMany(f => f.Strains)
                    .HasForeignKey(s => s.FlavorID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Strains_Flavors");
            });

            modelBuilder.Entity<Effects>(entity =>
            {
                entity.Property(model => model.Id).HasColumnName("id");
                entity.Property(model => model.Value).HasColumnName("value")
                    .HasMaxLength(25)
                    .IsRequired();
            });

            modelBuilder.Entity<Ailments>(entity =>
            {
                entity.Property(model => model.Id).HasColumnName("id");
                entity.Property(model => model.Value).HasColumnName("value")
                    .HasMaxLength(25)
                    .IsRequired();
            });

            modelBuilder.Entity<Flavors>(entity =>
            {
                entity.Property(model => model.Id).HasColumnName("id");
                entity.Property(model => model.Value).HasColumnName("value")
                    .HasMaxLength(25)
                    .IsRequired();
            });

            //.HasDefaultValue(false);

            //entity.HasOne(a => a.User)
            //.WithMany(u => u.Adventurers)
            //.HasForeignKey(a => a.UserId)
            //.OnDelete(DeleteBehavior.ClientSetNull)
            //.HasConstraintName("FK_Adventurers_Users");

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
