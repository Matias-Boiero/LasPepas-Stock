using LasPepas.Entidades.Enums;
using System.ComponentModel.DataAnnotations;

namespace LasPepas.Entidades.Dtos
{
    public class CajaDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "La fecha es requerida")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha")]
        public DateTime FechaCreacion { get; set; }
        [Display(Name = "Nombre del cliente")]
        [StringLength(30)]
        public string NombreCliente { get; set; }
        [Display(Name = "Método de pago")]
        public FormaPago_1? FormaPago_1 { get; set; }
        [Display(Name = "Nuevo método de pago")]
        public FormaPago_2? FormaPago_2 { get; set; }
        [Display(Name = "Pago en dinero efectivo")]
        public decimal? IngresoEfectivo { get; set; }
        [Display(Name = "Pago en Débito/Tarjeta/MercadoPago")]
        public decimal? IngresoBancario { get; set; }
        [Display(Name = "Nombre de la tarjeta")]
        public string? TipoTarjeta { get; set; }
        [Display(Name = "Número de cuotas")]
        public int? NroCuotas { get; set; }
        [Display(Name = "Egreso")]
        public decimal? Egreso { get; set; }
        [StringLength(30)]
        [Display(Name = "Tipo de egreso")]
        public string? TipoEgreso { get; set; }
        public decimal? Cambio { get; set; }

    }
}
