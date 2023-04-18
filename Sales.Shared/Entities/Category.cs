using System.ComponentModel.DataAnnotations;

namespace Sales.Shared.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Display(Name = "Categoría")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caractéres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]

        public string Name { get; set; } = null!;
    }
}
