using Microsoft.AspNetCore.Mvc.Rendering;
using SoftTicket.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SoftTicket.DAL.Entities
{
    public class Ticket : Entity
    {
        [Display(Name = "Ticket")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int TicketID { get; set; }

        [Display(Name = "Fecha Activación")]
        public DateTime? UseDate { get; set; }

        [Display(Name = "Ticket Activo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public bool IsUsed { get; set; }

        [Display(Name = "Entrada")]
        public Entrance? EntranceGate { get; set; }

        public enum Entrance
        {
            Norte,
            Sur,
            Oriental,
            Occidental
        }
    }
}
