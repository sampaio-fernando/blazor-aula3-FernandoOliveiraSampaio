using System.ComponentModel.DataAnnotations;

namespace AulaApp1.Components.Models
{
    public class Produto
    {
        [Required (ErrorMessage = "Nome obrigatório!")] 
        public string Nome { get; set; } = "";
        
        [Range(000.1, 100000, ErrorMessage = "O preço deve ser maior que R$ 00,00")]
        public decimal Preco { get; set; }
        
        public int Quantidade { get; set; }

    }

}
