using System.ComponentModel.DataAnnotations;

namespace SisOleoChangeBlazor.Modal
{
    public class Oleo
    {
        [Key]
        public int OleoId { get; set; }

        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no minimo {1} e no maximo {2}.")]
        [Required(ErrorMessage = "Informe o nome do oleo.")]
        [Display(Name = "Nome do Oleo")]
        public string Nome { get; set; }


        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no minimo {2} e no maximo {1}.")]
        [Required(ErrorMessage = "Informe o tipo de oleo.")]
        [Display(Name = "Tipo do Oleo")]
        public string TipoOleo { get; set; }

        //public int VeiculoId { get; set; }

        public virtual List<TrocaOleo> TrocaOleos { get; set; }
    }
}
