namespace FrontEnd.Models
{
    public class DoctorViewModel
    {
        public int IdDoctor { get; set; }
        public int IdUsuarioFk { get; set; }
        public List<UsuarioViewModel> Usuarios { get; set; }

    }
}
