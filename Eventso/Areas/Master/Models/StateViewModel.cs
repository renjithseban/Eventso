using Evento.Models.Helper;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Evento.Areas.Master.Models
{
    public class StateViewModel : GenericProperties
    {
        public int StateId { get; set; }

        [DisplayName("State Name")]
        [Required(ErrorMessage = "State name is required")]
        [StringLength(100, ErrorMessage = "State name shouldn't exceed 100 characters")]
        [Description("Name of the state")]
        public string StateName { get; set; }
    }
}