using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brasileirao_App.Models
{
    public class Estadio
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O campo Nome deve ter no máximo 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Data de Fundação é obrigatório.")]
        [Display(Name = "Data de Fundação")]
        [DataType(DataType.Date)]
        public DateTime DataFundacao { get; set; }

        [Required(ErrorMessage = "O campo Endereço é obrigatório.")]
        [StringLength(200, ErrorMessage = "O campo Endereço deve ter no máximo 200 caracteres.")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "O campo Cidade é obrigatório.")]
        [StringLength(100, ErrorMessage = "O campo Cidade deve ter no máximo 100 caracteres.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O campo UF é obrigatório.")]
        [ForeignKey("UF")]
        public int IdUf { get; set; }

        public bool Ativo { get; set; }

        public UF UF { get; set; }
    }
}
