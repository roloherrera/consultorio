namespace BackEnd.Models
{
    public class CitaModel
    {
        public int IdCitas { get; set; }
        public int IdUsuarioFk { get; set; }
        public int IdDoctorFk { get; set; }
        public string Condicion { get; set; } = null!;
        public DateTime Dia { get; set; }
        public DateTime Hora { get; set; }
        public bool Status { get; set; }
    }
}
