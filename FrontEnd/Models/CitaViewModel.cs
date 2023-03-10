using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FrontEnd.Models
{
    public class CitaViewModel
    {
        public int IdCitas { get; set; }

        [Display(Name = "Paciente")]
        public int IdUsuarioFk { get; set; }
        public List<UsuarioViewModel> Usuarios { get; set; }

        [Display(Name = "Doctor")]
        public int IdDoctorFk { get; set; }
        public List<DoctorViewModel> Doctores { get; set; }
        public string Condicion { get; set; } = null!;
        public DateTime Dia { get; set; }
        public DateTime Hora { get; set; }
        public bool Status { get; set; }
    }
}
