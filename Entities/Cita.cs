using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class Cita
    {
        public int IdCitas { get; set; }
        public int IdUsuarioFk { get; set; }
        public int IdDoctorFk { get; set; }
        public string Condicion { get; set; } = null!;
        public DateTime Dia { get; set; }
        public DateTime Hora { get; set; }
        public bool Status { get; set; }

        public virtual Doctore IdDoctorFkNavigation { get; set; } = null!;
        public virtual Usuario IdUsuarioFkNavigation { get; set; } = null!;
    }
}
