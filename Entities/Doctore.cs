using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class Doctore
    {
        public Doctore()
        {
            Cita = new HashSet<Cita>();
            Expedientes = new HashSet<Expediente>();
            Horarios = new HashSet<Horario>();
        }

        public int IdDoctor { get; set; }
        public int IdUsuarioFk { get; set; }

        public virtual Usuario IdUsuarioFkNavigation { get; set; } = null!;
        public virtual ICollection<Cita> Cita { get; set; }
        public virtual ICollection<Expediente> Expedientes { get; set; }
        public virtual ICollection<Horario> Horarios { get; set; }
    }
}
