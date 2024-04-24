using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MasterDetail
{
    public class TicketModel
    {
        [Range(0, 99999, ErrorMessage = "Number must be between 0 and 99999")]
        public int Number {  get; set; }

        [Required(ErrorMessage = "EventName is required")]
        [StringLength(128, ErrorMessage = "EventName cannot be longer than 128 characters")]
        public string EventName { get; set; } = "none";

        [Required(ErrorMessage = "PlaceName is required")]
        [StringLength(128, ErrorMessage = "PlaceName cannot be longer than 128 characters")]
        public string PlaceName { get; set; } = "none";

        [Range(0, 99999, ErrorMessage = "Price must be between 0 and 99999")]
        public int Price {  get; set; }


        public override string ToString() => $"{Number}";
    }
}
