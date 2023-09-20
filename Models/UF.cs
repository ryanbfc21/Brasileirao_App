using System;
using System.ComponentModel.DataAnnotations;

namespace Brasileirao_App.Models
{
    public class UF
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Sigla é obrigatório.")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "A Sigla deve ter exatamente 2 caracteres.")]
        public string Sigla { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O campo Nome deve ter no máximo 100 caracteres.")]
        public string Nome { get; set; }
    }
}
