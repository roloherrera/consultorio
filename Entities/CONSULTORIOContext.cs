using System;
using System.Collections.Generic;
using Entities.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Entities
{
    public partial class CONSULTORIOContext : DbContext
    {
        public CONSULTORIOContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<CONSULTORIOContext>();
            optionsBuilder.UseSqlServer(Utilities.Util.ConnectionString);
        }

        public CONSULTORIOContext(DbContextOptions<CONSULTORIOContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Abitacora> Abitacoras { get; set; } = null!;
        public virtual DbSet<Cita> Citas { get; set; } = null!;
        public virtual DbSet<Dia> Dias { get; set; } = null!;
        public virtual DbSet<Doctore> Doctores { get; set; } = null!;
        public virtual DbSet<Ebitacora> Ebitacoras { get; set; } = null!;
        public virtual DbSet<Expediente> Expedientes { get; set; } = null!;
        public virtual DbSet<Horario> Horarios { get; set; } = null!;
        public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Util.ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Abitacora>(entity =>
            {
                entity.HasKey(e => e.ConsecutivoAccion);

                entity.ToTable("ABITACORA");

                entity.Property(e => e.FechaHora).HasColumnType("datetime");

                entity.Property(e => e.Idusuario).HasColumnName("IDusuario");

                entity.Property(e => e.Origen)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cita>(entity =>
            {
                entity.HasKey(e => e.IdCitas)
                    .HasName("PK__Citas__B6881B51854FCF5D");

                entity.Property(e => e.Condicion)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("condicion");

                entity.Property(e => e.Dia).HasColumnType("date");

                entity.Property(e => e.Hora).HasColumnType("datetime");

                entity.Property(e => e.IdDoctorFk).HasColumnName("IdDoctorFK");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.IdDoctorFkNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.IdDoctorFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Citas__IdDoctorF__36B12243");

                entity.HasOne(d => d.IdUsuarioFkNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.IdUsuarioFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Citas__IdUsuario__37A5467C");
            });

            modelBuilder.Entity<Dia>(entity =>
            {
                entity.HasKey(e => e.IdDia)
                    .HasName("PK__Dias__3E41659716F42A35");

                entity.Property(e => e.IdDia).HasColumnName("idDia");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Doctore>(entity =>
            {
                entity.HasKey(e => e.IdDoctor)
                    .HasName("PK__Doctores__F838DB3EC9A9E41D");

                entity.Property(e => e.IdUsuarioFk).HasColumnName("IdUsuarioFK");

                entity.HasOne(d => d.IdUsuarioFkNavigation)
                    .WithMany(p => p.Doctores)
                    .HasForeignKey(d => d.IdUsuarioFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Doctores__IdUsua__34C8D9D1");
            });

            modelBuilder.Entity<Ebitacora>(entity =>
            {
                entity.HasKey(e => e.ConsecutivoError);

                entity.ToTable("EBITACORA");

                entity.Property(e => e.FechaHora).HasColumnType("datetime");

                entity.Property(e => e.Idusuario).HasColumnName("IDusuario");

                entity.Property(e => e.Origen)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Expediente>(entity =>
            {
                entity.HasKey(e => e.IdExpediente)
                    .HasName("PK__Expedien__101235DAC58BC0C4");

                entity.ToTable("Expediente");

                entity.Property(e => e.IdDoctorFk).HasColumnName("IdDoctorFK");

                entity.Property(e => e.Padecimiento)
                    .HasMaxLength(2500)
                    .IsUnicode(false);

                entity.Property(e => e.Tratamiento)
                    .HasMaxLength(2500)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDoctorFkNavigation)
                    .WithMany(p => p.Expedientes)
                    .HasForeignKey(d => d.IdDoctorFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Expedient__IdDoc__38996AB5");

                entity.HasOne(d => d.IdUsuarioFkNavigation)
                    .WithMany(p => p.Expedientes)
                    .HasForeignKey(d => d.IdUsuarioFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Expedient__IdUsu__398D8EEE");
            });

            modelBuilder.Entity<Horario>(entity =>
            {
                entity.HasKey(e => e.IdHorario)
                    .HasName("PK__Horario__DE60F33A5D7BDECD");

                entity.ToTable("Horario");

                entity.Property(e => e.IdHorario).HasColumnName("idHorario");

                entity.Property(e => e.HoraEntrada).HasColumnType("datetime");

                entity.Property(e => e.HoraSalida).HasColumnType("datetime");

                entity.Property(e => e.IdDiaFk).HasColumnName("IdDiaFK");

                entity.Property(e => e.IdDoctorFk).HasColumnName("IdDoctorFK");

                entity.HasOne(d => d.IdDiaFkNavigation)
                    .WithMany(p => p.Horarios)
                    .HasForeignKey(d => d.IdDiaFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Horario__IdDiaFK__33D4B598");

                entity.HasOne(d => d.IdDoctorFkNavigation)
                    .WithMany(p => p.Horarios)
                    .HasForeignKey(d => d.IdDoctorFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Horario__IdDocto__3A81B327");
            });

            modelBuilder.Entity<TipoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuario)
                    .HasName("PK__TipoUsua__03006BFF9E69BCD6");

                entity.ToTable("TipoUsuario");

                entity.Property(e => e.IdTipoUsuario).HasColumnName("idTipoUsuario");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuario__5B65BF97F27FB13F");

                entity.ToTable("Usuario");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cedula");

                entity.Property(e => e.Contrasenna)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.Genero)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("genero");

                entity.Property(e => e.IdTipoUsuarioFk).HasColumnName("idTipoUsuarioFk");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PrimerApellido)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("primerApellido");

                entity.Property(e => e.SegundoApellido)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("segundoApellido");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.Telefono).HasColumnName("telefono");

                entity.HasOne(d => d.IdTipoUsuarioFkNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdTipoUsuarioFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Usuario__idTipoU__35BCFE0A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
