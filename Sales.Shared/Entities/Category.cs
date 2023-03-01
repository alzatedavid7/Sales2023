using System.ComponentModel.DataAnnotations;

namespace Sales.Shared.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(80, ErrorMessage = "El campo {0} no puede tener mas de {1} caractéres")]
        public string Name { get; set; } = null!;
    }
}
