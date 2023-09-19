using System.ComponentModel.DataAnnotations;

namespace Brasileirao_App.Models
{
    public class Posicao
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [StringLength(50, ErrorMessage = "O campo Nome deve ter no máximo 50 caracteres.")]
        public string Nome { get; set; }

        [StringLength(200, ErrorMessage = "O campo Descrição deve ter no máximo 200 caracteres.")]
        public string Descricao { get; set; }
    }
}
