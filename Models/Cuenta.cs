using System.ComponentModel.DataAnnotations;

namespace API_Banco.Models
{
    public class Cuenta
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Saldo { get; set; }
    }
}
