using System.ComponentModel.DataAnnotations;

namespace APIPractica.Models
{
    public class ciudad
    {
        [Key]
        public int id_ciudad { get; set; }
        [Required]
        public string? nombreCiudad { get; set; }
    }
}
