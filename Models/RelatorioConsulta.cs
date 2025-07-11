namespace ClinicApp.Models;

public class RelatorioConsulta
{
    public int Id { get; set; }

    public string Procedimento { get; set; } = string.Empty;

    public double Preco { get; set; }

    public DateTime DataAgendada { get; set; }

    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; } = null!;
}