using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class Category
    {
        //Country se convierte en una tabla en la bd
        public int Id { get; set; }
        [Display(Name = "Categoría")]
        [MaxLength(50, ErrorMessage = "El campo{0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }
    }
}
