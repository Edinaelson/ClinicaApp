namespace ClinicApp.Models;

public class Agendamento
{
    public int Id { get; set; }
    public DateTime? DataAgendamento { get; set; }
    // Hora de início (ex: 08:00 AM no dia da DataAgendamento)
    public TimeSpan? HoraInicio { get; set; }
    // Hora de término/previsão (ex: 09:00 AM no dia da DataAgendamento)
    public TimeSpan? HoraFim { get; set; }
    public Titulo Titulo { get; set; } = null!;
    public Cliente Cliente { get; set; } = null!;
    public Status Status { get; set; } = null!;
}