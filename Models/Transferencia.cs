using System.ComponentModel.DataAnnotations;

namespace API_Banco.Models
{
    public class Transferencia
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Fecha { get; set; }

        [Required]
        public int Valor { get; set; }

        [Required]
        public int Id_Origen { get; set; }

        [Required]
        public int Id_Destino { get; set; }
    }
}
