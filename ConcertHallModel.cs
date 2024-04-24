using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetail
{
    public class ConcertHallModel
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(128, ErrorMessage = "Name cannot be longer than 128 characters")]
        public string Name { get; set; } = "none";

        [Required(ErrorMessage = "Adress is required")]
        [StringLength(128, ErrorMessage = "Adress cannot be longer than 128 characters")]
        public string Adress { get; set; } = "none";

        [Range(0, 9999, ErrorMessage = "Capacity must be between 0 and 9999")]
        public int Capacity { get; set; }

        [Required(ErrorMessage = "OpeningDate is required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime OpeningDate { get; set; }

        public BindingList<TicketModel> Tickets { get; } = new ();

        public void AddEmptyTicket() => Tickets.Add(new TicketModel());
        public void DeleteTicket(TicketModel ticket) => Tickets.Remove(ticket);

        public override string ToString() => $"{Name}";

    }
}
