using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TheTipTopSiteweb.Models
{
    public partial class thetiptoptestContext : DbContext
    {
        public thetiptoptestContext()
        {
        }

        public thetiptoptestContext(DbContextOptions<thetiptoptestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Coupon> Coupons { get; set; }
        public virtual DbSet<Lot> Lots { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Tuser> Tusers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=127.0.0.1;port=3307;database=thetiptoptest;user=root;password=momo", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.13-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            modelBuilder.Entity<Coupon>(entity =>
            {
                entity.HasKey(e => e.Idcoupon)
                    .HasName("PRIMARY");

                entity.ToTable("coupon");

                entity.Property(e => e.Idcoupon)
                    .HasColumnType("int(11)")
                    .HasColumnName("IDcoupon");

                entity.Property(e => e.CodeCoupon).HasColumnType("int(11)");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.DatefFin).HasColumnType("datetime");

                entity.Property(e => e.Etat)
                    .HasMaxLength(255)
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Idlot)
                    .HasColumnType("int(11)")
                    .HasColumnName("IDlot");

                entity.Property(e => e.Iduser)
                    .HasColumnType("int(11)")
                    .HasColumnName("IDuser");
            });

            modelBuilder.Entity<Lot>(entity =>
            {
                entity.HasKey(e => e.Idlot)
                    .HasName("PRIMARY");

                entity.ToTable("lot");

                entity.Property(e => e.Idlot)
                    .HasColumnType("int(11)")
                    .HasColumnName("IDlot");

                entity.Property(e => e.DescriptionLot)
                    .HasMaxLength(255)
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.NomLot)
                    .HasMaxLength(255)
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.Idrole)
                    .HasName("PRIMARY");

                entity.ToTable("role");

                entity.Property(e => e.Idrole)
                    .HasColumnType("int(11)")
                    .HasColumnName("IDRole");

                entity.Property(e => e.Role1)
                    .HasMaxLength(255)
                    .HasColumnName("Role")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<Tuser>(entity =>
            {
                entity.HasKey(e => e.Iduser)
                    .HasName("PRIMARY");

                entity.ToTable("tusers");

                entity.Property(e => e.Iduser)
                    .HasColumnType("int(11)")
                    .HasColumnName("IDuser");

                entity.Property(e => e.Adresse)
                    .HasMaxLength(255)
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CodePostal)
                    .HasMaxLength(255)
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Datenaissance).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Idrole)
                    .HasColumnType("int(11)")
                    .HasColumnName("IDRole");

                entity.Property(e => e.MotDepasse)
                    .HasMaxLength(255)
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Nom)
                    .HasMaxLength(255)
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Pays)
                    .HasMaxLength(255)
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Prenom)
                    .HasMaxLength(255)
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(255)
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Ville)
                    .HasMaxLength(255)
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
