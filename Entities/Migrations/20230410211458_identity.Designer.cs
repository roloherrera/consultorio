﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Entities.Migrations
{
    [DbContext(typeof(CONSULTORIOContext))]
    [Migration("20230410211458_identity")]
    partial class identity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Abitacora", b =>
                {
                    b.Property<int>("ConsecutivoAccion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConsecutivoAccion"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime");

                    b.Property<int>("Idusuario")
                        .HasColumnType("int")
                        .HasColumnName("IDusuario");

                    b.Property<string>("Origen")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("ConsecutivoAccion");

                    b.ToTable("ABITACORA", (string)null);
                });

            modelBuilder.Entity("Entities.Authentication.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Entities.Cita", b =>
                {
                    b.Property<int>("IdCitas")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCitas"), 1L, 1);

                    b.Property<string>("Condicion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("condicion");

                    b.Property<DateTime>("Dia")
                        .HasColumnType("date");

                    b.Property<DateTime>("Hora")
                        .HasColumnType("datetime");

                    b.Property<int>("IdDoctorFk")
                        .HasColumnType("int")
                        .HasColumnName("IdDoctorFK");

                    b.Property<int>("IdUsuarioFk")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit")
                        .HasColumnName("status");

                    b.HasKey("IdCitas")
                        .HasName("PK__Citas__B6881B51854FCF5D");

                    b.HasIndex("IdDoctorFk");

                    b.HasIndex("IdUsuarioFk");

                    b.ToTable("Citas");
                });

            modelBuilder.Entity("Entities.Dia", b =>
                {
                    b.Property<int>("IdDia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idDia");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDia"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("descripcion");

                    b.HasKey("IdDia")
                        .HasName("PK__Dias__3E41659716F42A35");

                    b.ToTable("Dias");
                });

            modelBuilder.Entity("Entities.Doctore", b =>
                {
                    b.Property<int>("IdDoctor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDoctor"), 1L, 1);

                    b.Property<int>("IdUsuarioFk")
                        .HasColumnType("int")
                        .HasColumnName("IdUsuarioFK");

                    b.HasKey("IdDoctor")
                        .HasName("PK__Doctores__F838DB3EC9A9E41D");

                    b.HasIndex("IdUsuarioFk");

                    b.ToTable("Doctores");
                });

            modelBuilder.Entity("Entities.Ebitacora", b =>
                {
                    b.Property<int>("ConsecutivoError")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConsecutivoError"), 1L, 1);

                    b.Property<int>("CodigoError")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime");

                    b.Property<int>("Idusuario")
                        .HasColumnType("int")
                        .HasColumnName("IDusuario");

                    b.Property<string>("Origen")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("ConsecutivoError");

                    b.ToTable("EBITACORA", (string)null);
                });

            modelBuilder.Entity("Entities.Expediente", b =>
                {
                    b.Property<int>("IdExpediente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdExpediente"), 1L, 1);

                    b.Property<int>("IdDoctorFk")
                        .HasColumnType("int")
                        .HasColumnName("IdDoctorFK");

                    b.Property<int>("IdUsuarioFk")
                        .HasColumnType("int");

                    b.Property<string>("Padecimiento")
                        .IsRequired()
                        .HasMaxLength(2500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(2500)");

                    b.Property<string>("Tratamiento")
                        .IsRequired()
                        .HasMaxLength(2500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(2500)");

                    b.HasKey("IdExpediente")
                        .HasName("PK__Expedien__101235DAC58BC0C4");

                    b.HasIndex("IdDoctorFk");

                    b.HasIndex("IdUsuarioFk");

                    b.ToTable("Expediente", (string)null);
                });

            modelBuilder.Entity("Entities.Horario", b =>
                {
                    b.Property<int>("IdHorario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idHorario");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdHorario"), 1L, 1);

                    b.Property<DateTime>("HoraEntrada")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("HoraSalida")
                        .HasColumnType("datetime");

                    b.Property<int>("IdDiaFk")
                        .HasColumnType("int")
                        .HasColumnName("IdDiaFK");

                    b.Property<int>("IdDoctorFk")
                        .HasColumnType("int")
                        .HasColumnName("IdDoctorFK");

                    b.HasKey("IdHorario")
                        .HasName("PK__Horario__DE60F33A5D7BDECD");

                    b.HasIndex("IdDiaFk");

                    b.HasIndex("IdDoctorFk");

                    b.ToTable("Horario", (string)null);
                });

            modelBuilder.Entity("Entities.TipoUsuario", b =>
                {
                    b.Property<int>("IdTipoUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idTipoUsuario");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoUsuario"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("descripcion");

                    b.HasKey("IdTipoUsuario")
                        .HasName("PK__TipoUsua__03006BFF9E69BCD6");

                    b.ToTable("TipoUsuario", (string)null);
                });

            modelBuilder.Entity("Entities.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsuario"), 1L, 1);

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("cedula");

                    b.Property<string>("Contrasenna")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("date");

                    b.Property<string>("Genero")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("genero");

                    b.Property<int>("IdTipoUsuarioFk")
                        .HasColumnType("int")
                        .HasColumnName("idTipoUsuarioFk");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("PrimerApellido")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("primerApellido");

                    b.Property<string>("SegundoApellido")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("segundoApellido");

                    b.Property<bool>("State")
                        .HasColumnType("bit")
                        .HasColumnName("state");

                    b.Property<int>("Telefono")
                        .HasColumnType("int")
                        .HasColumnName("telefono");

                    b.HasKey("IdUsuario")
                        .HasName("PK__Usuario__5B65BF97F27FB13F");

                    b.HasIndex("IdTipoUsuarioFk");

                    b.ToTable("Usuario", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Entities.Cita", b =>
                {
                    b.HasOne("Entities.Doctore", "IdDoctorFkNavigation")
                        .WithMany("Cita")
                        .HasForeignKey("IdDoctorFk")
                        .IsRequired()
                        .HasConstraintName("FK__Citas__IdDoctorF__36B12243");

                    b.HasOne("Entities.Usuario", "IdUsuarioFkNavigation")
                        .WithMany("Cita")
                        .HasForeignKey("IdUsuarioFk")
                        .IsRequired()
                        .HasConstraintName("FK__Citas__IdUsuario__37A5467C");

                    b.Navigation("IdDoctorFkNavigation");

                    b.Navigation("IdUsuarioFkNavigation");
                });

            modelBuilder.Entity("Entities.Doctore", b =>
                {
                    b.HasOne("Entities.Usuario", "IdUsuarioFkNavigation")
                        .WithMany("Doctores")
                        .HasForeignKey("IdUsuarioFk")
                        .IsRequired()
                        .HasConstraintName("FK__Doctores__IdUsua__34C8D9D1");

                    b.Navigation("IdUsuarioFkNavigation");
                });

            modelBuilder.Entity("Entities.Expediente", b =>
                {
                    b.HasOne("Entities.Doctore", "IdDoctorFkNavigation")
                        .WithMany("Expedientes")
                        .HasForeignKey("IdDoctorFk")
                        .IsRequired()
                        .HasConstraintName("FK__Expedient__IdDoc__38996AB5");

                    b.HasOne("Entities.Usuario", "IdUsuarioFkNavigation")
                        .WithMany("Expedientes")
                        .HasForeignKey("IdUsuarioFk")
                        .IsRequired()
                        .HasConstraintName("FK__Expedient__IdUsu__398D8EEE");

                    b.Navigation("IdDoctorFkNavigation");

                    b.Navigation("IdUsuarioFkNavigation");
                });

            modelBuilder.Entity("Entities.Horario", b =>
                {
                    b.HasOne("Entities.Dia", "IdDiaFkNavigation")
                        .WithMany("Horarios")
                        .HasForeignKey("IdDiaFk")
                        .IsRequired()
                        .HasConstraintName("FK__Horario__IdDiaFK__33D4B598");

                    b.HasOne("Entities.Doctore", "IdDoctorFkNavigation")
                        .WithMany("Horarios")
                        .HasForeignKey("IdDoctorFk")
                        .IsRequired()
                        .HasConstraintName("FK__Horario__IdDocto__3A81B327");

                    b.Navigation("IdDiaFkNavigation");

                    b.Navigation("IdDoctorFkNavigation");
                });

            modelBuilder.Entity("Entities.Usuario", b =>
                {
                    b.HasOne("Entities.TipoUsuario", "IdTipoUsuarioFkNavigation")
                        .WithMany("Usuarios")
                        .HasForeignKey("IdTipoUsuarioFk")
                        .IsRequired()
                        .HasConstraintName("FK__Usuario__idTipoU__35BCFE0A");

                    b.Navigation("IdTipoUsuarioFkNavigation");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Entities.Authentication.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Entities.Authentication.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Authentication.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Entities.Authentication.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Dia", b =>
                {
                    b.Navigation("Horarios");
                });

            modelBuilder.Entity("Entities.Doctore", b =>
                {
                    b.Navigation("Cita");

                    b.Navigation("Expedientes");

                    b.Navigation("Horarios");
                });

            modelBuilder.Entity("Entities.TipoUsuario", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Entities.Usuario", b =>
                {
                    b.Navigation("Cita");

                    b.Navigation("Doctores");

                    b.Navigation("Expedientes");
                });
#pragma warning restore 612, 618
        }
    }
}
