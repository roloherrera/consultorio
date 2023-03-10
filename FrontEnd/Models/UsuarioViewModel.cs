using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FrontEnd.Models
{
    public class UsuarioViewModel
    {
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
        [Display(Name = "UserType")]
        public int IdTipoUsuarioFk { get; set; }
        public IEnumerable<UsertypeViewModel> TipoUsuario { get; set; }
        public bool State { get; set; }
    }
}
