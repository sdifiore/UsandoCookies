using System.ComponentModel.DataAnnotations;

namespace UsandoCookies.Models
{
    public class Mensagem
    {
        [StringLength(4096)]
        [Display(Name = "Digite o texto a ser gravado:")]
        [Required(ErrorMessage = "Comprimento máximo de 256 caracteres")]
        public string Entrada { get; set; }

        [Display(Name = "Resultado lido:")]
        public string Saida { get; set; }
    }
}
