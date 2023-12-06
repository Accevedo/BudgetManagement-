using ManejoPresupuestos.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuestos.Models
{
    public class TipoCUenta
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength:50, MinimumLength =3, ErrorMessage = "La longitd del campo {0} es entre {2} y {1}")]
        [PrimeraLetraMayuscula]
        public string Nombre { get; set; }
        public int UsusarioID { get; set; }
        public int Orden { get; set; }

        //otros tipos de validaciones por defecto

        [Range(minimum:18,  maximum:99, ErrorMessage ="the range age goign from {1} and {2}")]
        public int edad { get; set; }
        [Required(ErrorMessage = "This field must be fill")]
        [EmailAddress(ErrorMessage ="This email is not valid")]
        public string? Email { get; set; }
        [CreditCard(ErrorMessage = "This credit card is not valid ")]
        [Display(Name = "tarjeta de Credito")]
        public int TarjetaDeCredito  { get; set; }
    }
}
