using System.ComponentModel.DataAnnotations;

namespace Calculadora.Models
{
    public class OperacionModel
    {
        [Required(ErrorMessage = "Ingresa el primer número")]
        [Display(Name = "Primer número")]
        public double Numero1 { get; set; }

        [Required(ErrorMessage = "Ingresa el segundo número")]
        [Display(Name = "Segundo número")]
        public double Numero2 { get; set; }

        [Required(ErrorMessage = "Selecciona una operación")]
        [Display(Name = "Operación")]
        public string Operacion { get; set; } = "suma";

        public double? Resultado { get; set; }

        public string? Error { get; set; }
    }
}