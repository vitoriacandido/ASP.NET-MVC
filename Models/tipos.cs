using System.ComponentModel.DataAnnotations;
namespace app_tarefas.Models;

public class Tipos
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "O campo Nome é obrigatório.")]
    [MinLength(2, ErrorMessage = "O campo Nome deve ter pelo menos 2 caracteres.")]
    [MaxLength(100, ErrorMessage = "O campo Nome deve ter no máximo 100 caracteres.")]
    public string Nome { get; set; } = null!;

   [Required(ErrorMessage = "O campo Descrição é obrigatório.")]
   [MinLength(5, ErrorMessage = "O campo Descrição deve ter pelo menos 5 caracteres.")]
   [MaxLength(500, ErrorMessage = "O campo Descrição deve ter no máximo 500 caracteres.")]
   public string Descricao { get; set; } = null!;
}
  
