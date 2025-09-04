using Orders.Shared.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Orders.Shared.Entities;

public class Country : IEntityWithName
{
    public int Id { get; set; }

    [Display(Name = "País")]
    [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
    [Required(ErrorMessage = "El campo {0} es obligatorio.")]
    public string Name { get; set; } = null!;

    public ICollection<State>? States { get; set; }

    public int StatesNumber => States == null ? 0 : States.Count;
}