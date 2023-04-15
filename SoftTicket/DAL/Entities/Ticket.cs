using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SoftTicket.DAL.Entities
{
    public class Ticket : Entity
    {
        [Display(Name = "Fecha Uso")]
        [MaxLength(50)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public DateTime? UseDate { get; set; }

        [Display(Name = "Estado")]
        [MaxLength(50)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public bool IsUsed { get; set; }

        [Display(Name = "Entrada")]
        [MaxLength(50)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? EntranceGate { get; set; }

    }
}
