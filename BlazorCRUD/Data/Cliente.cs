using System.ComponentModel.DataAnnotations;

namespace BlazorCRUD.Data
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Campo Obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "El correo electrónico no es válido.")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public DateTime Fecha { get; set; }

    }
}
