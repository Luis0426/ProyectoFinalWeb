using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Paginas_Enchiladas.Models
{
    public class Enchilada //Clase enchilada donde se definen los atributos de la tabla
    {
        [Key] //Se define que es la llave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_Enchilada { get; set; }

        [Required] //Se indica que se requiere ese campo
        [DisplayName("Tipo de Tortilla")] //Se indica que este campo se va a mostrar de esta manera
        public string? Tipo_tortilla { get; set; }
        [Required]       
        public string? Relleno { get; set; }
        [Required]
        public string? Salsa { get; set; }
        [Required]
        public float Precio { get; set; }

    }
}
