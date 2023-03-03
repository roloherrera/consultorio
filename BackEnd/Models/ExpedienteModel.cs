namespace BackEnd.Models
{
    public class ExpedienteModel
    {
        public int IdExpediente { get; set; }
        public int IdUsuarioFk { get; set; }
        public int IdDoctorFk { get; set; }
        public string Padecimiento { get; set; } = null!;
        public string Tratamiento { get; set; } = null!;

    }
}
