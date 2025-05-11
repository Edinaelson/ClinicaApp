using System.ComponentModel.DataAnnotations;

namespace ClinicApp.Models;

public class Cliente
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Nome obrigatorio")]
    public string? Nome { get; set; }
    
    [Required(ErrorMessage = "Email obrigatorio")]
    public string? Email { get; set; }
    
    public string? Telefone { get; set; }

    [Required(ErrorMessage = "campo requerido")]
    public DateTime? DataNascimento { get; set; }
    
    [Required(ErrorMessage = "CPF obrigatorio")]
    public  string Cpf { get; set; }
    
}