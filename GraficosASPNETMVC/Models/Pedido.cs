namespace GraficosASPNETMVC.Models
{
    public class Pedido
    {
       // Armazena os itens comprados 
        public int Id { get; set; }
        public List<ItemPedido> Itens { get; set; } // Relacionamento com os itens do pedido. 
    }
}
