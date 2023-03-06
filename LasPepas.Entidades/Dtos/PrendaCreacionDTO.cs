using LasPepas.Entidades.Enums;
using LasPepas.Enums;
using System.ComponentModel.DataAnnotations;

namespace LasPepas.Entidades.Dtos
{
    public class PrendaCreacionDTO
    {
        [Required(ErrorMessage = "El código es requerido")]
        [MaxLength(10)]
        public string Id { get; set; }
        [Required(ErrorMessage = "La fecha es requerida")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de creación de la prenda")]
        public DateTime FechaCreacion { get; set; }
        [Required(ErrorMessage = "El tipo de marca es requerido")]
        public Marca Marca { get; set; }
        [Required(ErrorMessage = "El tipo de prenda es requerido")]
        public TipoPrenda TipoPrenda { get; set; }
        [Required(ErrorMessage = "La temporada es requerido")]
        public Temporada Temporada { get; set; }
        [Required(ErrorMessage = "La descripción es requerida")]
        [MaxLength(40)]
        public string Descripción { get; set; }
        [Required(ErrorMessage = "El talle es requerido")]
        [MaxLength(10)]
        public string Talle { get; set; }
        [Required(ErrorMessage = "El Precio es requerido")]
        [Range(1, 60000)]
        public decimal Precio { get; set; }
        [Required]
        public bool Disponible { get; set; }
        public decimal? VentaContado { get; set; }
        public decimal? VentaCtaCorriente { get; set; }
        public decimal? VentaTarjeta { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? FechaVenta { get; set; }
        public TipoVenta? TipoVenta { get; set; }
        [MaxLength(40)]
        public string? Cliente { get; set; }
        [MaxLength(50)]
        public string? Observaciones { get; set; }
    }
}
