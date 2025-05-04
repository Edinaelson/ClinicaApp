using System.ComponentModel.DataAnnotations;

namespace ClinicApp.Models;

public class Cliente
{
    public int Id { get; set; }
    
    [Required]
    public string Nome { get; set; }
    
    [Required, EmailAddress(ErrorMessage = "Email obrigatorio")]
    public string Email { get; set; }
    
    public string Telefone { get; set; }

    [Required(ErrorMessage = "campo requerido")]
    public DateTime? DataNascimento { get; set; }
    
}