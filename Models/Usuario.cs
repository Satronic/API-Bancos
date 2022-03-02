using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace API_Banco.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Nombres { get; set; }

        [Required]
        public string Apellidos { get; set; }

        [Required]
        public int Cuenta_Id { get; set; }
    }
}
