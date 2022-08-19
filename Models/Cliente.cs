using System.ComponentModel.DataAnnotations;

namespace APIPractica.Models
{
    public class Cliente
    {
        [Key]
        public int? IdCliente { get; set; }
        [Required]
        public string? cedula{ get; set; }
        [Required]
        public string? nombres { get; set; }
        [Required]
        public string? apellidos { get; set; }
        [Required]
        public string? direccion { get; set; }
        [Required]
        public int? edad { get; set; }
        [Required]
        public int? idCiudad { get; set; }
        //[Required]
        //public string? nombreCiudad { get; set; }
    }
}
