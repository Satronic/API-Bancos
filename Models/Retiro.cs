using System.ComponentModel.DataAnnotations;

namespace API_Banco.Models
{
    public class Retiro
    {
        [Required]
        public int Id { get; set; }

        public int Fecha { get; set; }

        public int Valor { get; set; }
    }
}
