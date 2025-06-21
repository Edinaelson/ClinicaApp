using System;

namespace ClinicApp.Models;

public class Compromisso
{
    public int Id { get; set; }
    public string? Descricao { get; set; }
    public DateTime Data { get; set; }
    public int PacienteId { get; set; }
    public int AgendamentoId { get; set; }
    public int? UsuarioId { get; set; }
    public Usuario? Usuario { get; set; }
    public bool? Concluido { get; set; }
}