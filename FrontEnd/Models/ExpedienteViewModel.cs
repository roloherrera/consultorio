using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FrontEnd.Models
{
    public class ExpedienteViewModel
    {
        public int IdExpediente { get; set; }
        [Display(Name = "Paciente")]
        public int IdUsuarioFk { get; set; }
        public List<UsuarioViewModel> Usuarios { get; set; }
        [Display(Name = "Doctor")]
        public int IdDoctorFk { get; set; }
        public List<DoctorViewModel> Doctores { get; set; }
        public string Padecimiento { get; set; } = null!;
        public string Tratamiento { get; set; } = null!;
    }
}
