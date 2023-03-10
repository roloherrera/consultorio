namespace FrontEnd.Models
{
    public class HorarioViewModel
    {
        public int IdHorario { get; set; }
        public int IdDiaFk { get; set; }
        public int IdDoctorFk { get; set; }
        public List<DoctorViewModel> Doctores { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSalida { get; set; }
    }
}
