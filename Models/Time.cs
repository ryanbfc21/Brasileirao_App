using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brasileirao_App.Models
{
    public class Time
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

        [ForeignKey("Estadio")]
        public int IdEstadio { get; set; }

        public Estadio EstadioNavigation { get; set; }
    }
}
