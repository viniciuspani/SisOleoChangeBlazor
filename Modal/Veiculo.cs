using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using SisOleoChangeBlazor.Context;

namespace SisOleoChangeBlazor.Modal
{
    public class Veiculo
    {
        [Key]
        public int VeiculoId { get; set; }


        //[StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no minimo {1} e no maximo {2}.")]
        [Required(ErrorMessage = "Informe o nome do veiculo.")]
        [Display(Name = "Nome do veiculo")]
        public string Modelo { get; set; }

        //[StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no minimo {1} e no maximo {2}.")]
        [Required(ErrorMessage = "Informe o fabricante do veiculo.")]
        [Display(Name = "Fabricante do veiculo")]
        public string Fabricante { get; set; }


        [Required(ErrorMessage = "Informe o ano de fabricação do veiculo.")]
        [Range(-0, int.MaxValue)]
        [Display(Name = "Ano de fabricação")]
        public int AnoFabricacao { get; set; }


        [StringLength(80, MinimumLength = 5, ErrorMessage = "O {0} deve ter no minimo {2} e no maximo {1}.")]
        [Required(ErrorMessage = "Informe o tipo de veiculo.")]
        [Display(Name = "Tipo de Veiculo")]
        public string TipoVeiculo { get; set; }

        //public virtual List<Oleo> Oleo { get; set; }

        //public virtual List<Filtro> Filtro { get; set; }

        public virtual List<TrocaOleo>? TrocaOleos { get; set; }
    }
}


