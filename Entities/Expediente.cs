using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class Expediente
    {
        public int IdExpediente { get; set; }
        public int IdUsuarioFk { get; set; }
        public int IdDoctorFk { get; set; }
        public string Padecimiento { get; set; } = null!;
        public string Tratamiento { get; set; } = null!;

        public virtual Doctore IdDoctorFkNavigation { get; set; } = null!;
        public virtual Usuario IdUsuarioFkNavigation { get; set; } = null!;
    }
}
