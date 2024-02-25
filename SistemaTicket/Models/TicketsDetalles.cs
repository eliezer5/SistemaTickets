using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaTicket.Models
{
    public class TicketsDetalles
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("TicketId")]
        public int TicketId { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Este campo no acepta digitos")]
        public string Emisor {  get; set; }

        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Este campo no acepta digitos")]
        public string Mensaje { get; set; }
    }
}
