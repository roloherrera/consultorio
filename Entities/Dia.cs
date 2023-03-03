using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class Dia
    {
        public Dia()
        {
            Horarios = new HashSet<Horario>();
        }

        public int IdDia { get; set; }
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<Horario> Horarios { get; set; }
    }
}
