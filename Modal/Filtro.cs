using System.ComponentModel.DataAnnotations;

namespace SisOleoChangeBlazor.Modal
{
    public class Filtro
    {
        [Key]
        public int FiltroId { get; set; }

        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no minimo {1} e no maximo {2}.")]
        [Required(ErrorMessage = "Informe o nome do filtro.")]
        [Display(Name = "Nome do Filtro")]
        public string Nome { get; set; }

        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no minimo {1} e no maximo {2}.")]
        [Required(ErrorMessage = "Informe o tipo de filtro.")]
        [Display(Name = "Tipo de Filtro")]
        public string TipoFiltro { get; set; }

        //public int VeiculoId { get; set; }
        public virtual List<TrocaOleo> TrocaOleos { get; set; }
    }
}
