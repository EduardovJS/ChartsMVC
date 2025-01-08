using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraficosASPNETMVC.ViewModels
{
    public class VendasViewModel
    {
        [Required(ErrorMessage = "Essa informação é obrigatória.")]
        public int Quantidade { get; set; }

    }
}
