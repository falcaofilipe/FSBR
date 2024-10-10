using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace desafioMVC.Models
{
    public class Npu
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DisplayName("Nome do Processo")]
        public string nomeProcesso { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DisplayName("NPU")]
        [StringLength(25, MinimumLength = 25, ErrorMessage = "O campo {0} está em formato incorreto")]
        public string npu { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DataType(DataType.Date, ErrorMessage = "O campo {0} está em formato incorreto")]
        [DisplayName("Data de Cadastro")]
        public string dataCadastro { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DataType(DataType.Date, ErrorMessage = "O campo {0} está em formato incorreto")]
        [DisplayName("Data de Visualização")]
        public string dataVisualizacao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DisplayName("UF")]
        public string uf { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DisplayName("Municipio")]
        public string municipio { get; set; }

        [NotMapped]
        public List<SelectListItem>? ListaMunicipio { get; set; }

        [NotMapped]
        public List<SelectListItem>? ListaUf { get; set; }
    }
}
