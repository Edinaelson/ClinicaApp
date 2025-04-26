namespace ClinicApp.Models;

public class Agendamento
{
    public int Id { get; set; }
    public DateTime Data { get; set; }
    public string Descricao { get; set; }
    public int PacienteId { get; set; }
    
    public Paciente? Paciente { get; set; }
}