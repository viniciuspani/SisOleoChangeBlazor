using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SisOleoChangeBlazor.Modal
{
    [Table("TrocaOleo")]
    public class TrocaOleo
    {
        [Key]
        public int TrocaOleoId { get; set; }

        public int VeiculoId { get; set; }

        public int OleoId { get; set; }

        public int FiltroId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Required(ErrorMessage ="Informe a quilometragem atual.")]
        public double KmAtual { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Required(ErrorMessage = "Informe a quilometragem da proxima troca.")]
        public double KmProximaTroca { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Quantidade de litro de oleo")]
        public double QuantidadeOleo { get; set; }

        [Required(ErrorMessage = "Informe a data da troca de oleo.")]
        public DateTime DataTroca = DateTime.Now;

        public DateTime? DataProximaTroca { get; set; }
    }
}
