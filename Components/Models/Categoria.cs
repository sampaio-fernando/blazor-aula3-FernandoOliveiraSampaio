using System.ComponentModel.DataAnnotations;

namespace AulaApp1.Components.Models;

public class Categoria
{
    [Required(ErrorMessage = "Descrição obrigatória")]
    [MinLength(3, ErrorMessage = "Mínimo 3 caracteres!")]
    [RegularExpression(@"^[a-zA-ZÀ-ÿ\s]+$", ErrorMessage = "Somente letras e espaços")]
    //Terceira regra: A validação é necessária para evitar o armazenamento de números ou caracteres especiais.
    public string? Nome { get; set; }

    [Range(0, 100000, ErrorMessage = "Quantidade fora do limite!")]
    public double Quantidade { get; set; } = 0;
}