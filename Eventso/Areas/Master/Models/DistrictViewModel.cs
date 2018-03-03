using Evento.Models.Helper;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Evento.Areas.Master.Models
{
    public class DistrictViewModel:GenericProperties
    {
        public int DistrictId { get; set; }

        [DisplayName("District Name")]
        [Required(ErrorMessage = "District name is required")]
        [StringLength(100, ErrorMessage = "District name shouldn't exceed 100 characters")]
        [Description("Name of the district")]
        public string DistrictName { get; set; }

        public int StateId { get; set; }

        public StateViewModel State { get; set; }
    }
}