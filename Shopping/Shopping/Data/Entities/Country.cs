using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class Country
    {
        //Country se convierte en una tabla en la bd
        public int Id { get; set; }
        [Display (Name ="País")]
        [MaxLength(50,ErrorMessage ="El campo{0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage ="El campo {0} es obligatorio.")]
        public string Name { get; set; }
        //Relacionar
        public ICollection<State> States { get; set; }

        [Display(Name = "Departamentos/Estados")]
        //propiedad de solo lectura(=> el StatesNumber es igual a ).
        //Operador ternario("?" if de una sola linea) 
        //if States == null entonces devolvera 0 de los contrario States.Count;
        public int StatesNumber => States == null ? 0 : States.Count;
    }
}
