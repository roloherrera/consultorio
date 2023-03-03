using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class Horario
    {
        public int IdHorario { get; set; }
        public int IdDiaFk { get; set; }
        public int IdDoctorFk { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSalida { get; set; }

        public virtual Dia IdDiaFkNavigation { get; set; } = null!;
        public virtual Doctore IdDoctorFkNavigation { get; set; } = null!;
    }
}
