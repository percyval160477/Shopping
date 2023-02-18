using System.ComponentModel.DataAnnotations;

namespace Shopping.Models
{
    public class CityViewModel
    {
        //Country se convierte en una tabla en la bd
        public int Id { get; set; }
        [Display(Name = "Ciudad")]
        [MaxLength(50, ErrorMessage = "El campo{0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }
        //A que estado pertenece una ciudad
        public int StateId { get; set; }

    }
}
