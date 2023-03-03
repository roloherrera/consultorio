namespace BackEnd.Models
{
    public class HorarioModel
    {
        public int IdHorario { get; set; }
        public int IdDiaFk { get; set; }
        public int IdDoctorFk { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSalida { get; set; }
    }
}
