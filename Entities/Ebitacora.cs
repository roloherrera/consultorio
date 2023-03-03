using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class Ebitacora
    {
        public int ConsecutivoError { get; set; }
        public int Idusuario { get; set; }
        public DateTime FechaHora { get; set; }
        public int CodigoError { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Origen { get; set; } = null!;
    }
}
