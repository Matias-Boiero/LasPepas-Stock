using LasPepas.Entidades.Enums;
using LasPepas.Enums;
using System.ComponentModel.DataAnnotations;

namespace LasPepas.Entidades
{
    public class Prenda
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El código es requerido")]
        [MaxLength(20)]
        public string Codigo { get; set; }
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
        public decimal? Precio { get; set; }
        [Required]
        public bool Disponible { get; set; }
        public decimal? VentaContado { get; set; }
        //public decimal? Entrega { get; set; }
        public bool VentaCtaCorriente { get; set; }
        public bool Condicional { get; set; }
        public decimal? VentaTarjeta { get; set; }
        [Display(Name = "Fecha de venta de la prenda")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? FechaVenta { get; set; }
        [MaxLength(40)]
        public string? Cliente { get; set; }
        [MaxLength(50)]
        public string? Observaciones { get; set; }
        public Vendedor? Vendedor { get; set; }
    }
}
