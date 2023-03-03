using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class Usuario
    {
        public Usuario()
        {
            Cita = new HashSet<Cita>();
            Doctores = new HashSet<Doctore>();
            Expedientes = new HashSet<Expediente>();
        }

        public int IdUsuario { get; set; }
        public string Nombre { get; set; } = null!;
        public string PrimerApellido { get; set; } = null!;
        public string? SegundoApellido { get; set; }
        public string Cedula { get; set; } = null!;
        public int Telefono { get; set; }
        public string Email { get; set; } = null!;
        public string? Genero { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Contrasenna { get; set; } = null!;
        public int IdTipoUsuarioFk { get; set; }
        public bool State { get; set; }

        public virtual TipoUsuario IdTipoUsuarioFkNavigation { get; set; } = null!;
        public virtual ICollection<Cita> Cita { get; set; }
        public virtual ICollection<Doctore> Doctores { get; set; }
        public virtual ICollection<Expediente> Expedientes { get; set; }
    }
}
