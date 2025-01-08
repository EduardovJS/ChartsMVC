using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GraficosASPNETMVC.Models
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; } // Referência ao Produto
        public Produto Produto { get; set; } // Navegação para o Produto

        [Required(ErrorMessage = "Essa informação é obrigatória.")]
        public int Quantidade { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorUnitario { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorTotal { get; set; }
    }
}
