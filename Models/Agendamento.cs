namespace ClinicApp.Models;

public class Agendamento
{
    public int Id { get; set; }
    public DateTime? DataAgendamento { get; set; }
    public string Status { get; set; }
    public int ClientId { get; set; }
    
    public Cliente Cliente { get; set; } = null!;
}