using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class City
    {
        //Country se convierte en una tabla en la bd
        public int Id { get; set; }
        [Display(Name = "Ciudad")]
        [MaxLength(50, ErrorMessage = "El campo{0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }
        //Unda ciudad pertenece a un Estado
        public State State { get; set; }
        //Una ciudad tiene muchos usuarios que pertecen a la ciudad
        public ICollection<User> Users { get; set; } 
    }
}
