using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaTicket.Models
{
    public class Tickets
    {
        [Key]
        public int TicketId { get; set; }

        [Required(ErrorMessage = "La Fecha es requerida")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "El SolicitadoPor es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El SolicitadoPor no puede tener más de 100 caracteres.")]
        public string? SolicitadoPor { get; set; }

        [Required(ErrorMessage = "El Asunto es obligatorio.")]
        [MaxLength(255, ErrorMessage = "El Asunto no puede tener más de 255 caracteres.")]
        public string? Asunto { get; set; }

        [Required(ErrorMessage = "La Descripcion es obligatoria.")]
        public string? Descripcion { get; set; }

    }
}
