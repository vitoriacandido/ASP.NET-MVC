
using System.ComponentModel.DataAnnotations;
using app_tarefas.Models;

namespace ASP.NET_MVC.Models;

public class Tarefas
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "O campo Nome é obrigatório.")]
    [MinLength(2, ErrorMessage = "O campo Nome deve ter pelo menos 2 caracteres.")]
    [MaxLength(100, ErrorMessage = "O campo Nome deve ter no máximo 100 caracteres.")]
    [Display(Name = "Titulo")]
    public string Nome { get; set; } = string.Empty;
    [Required(ErrorMessage = "O campo Descrição é obrigatório.")]
    [MinLength(5, ErrorMessage = "O campo Descrição deve ter pelo menos 5 caracteres.")]
    [MaxLength(200, ErrorMessage = "O campo Descrição deve ter no máximo 200 caracteres.")]
    [Display(Name = "Descrição")]
    public string Descricao { get; set; } = string.Empty;
    [DataType(DataType.Date)]
    [Display(Name = "Data de Criação")]
    public DateTime DataCriacao { get; set; } = DateTime.Now;
    [DataType(DataType.Date)]
    [Display(Name = "Data de Conclusão")]
    public DateTime DataConclusao { get; set; } = DateTime.Now;

    public int TipoId { get; set; }
    public Tipos? Tipo { get; set; } = null!;
    public bool Concluida { get; set; } = false;

    public Tarefas() { DataCriacao = DateTime.Now; }

}