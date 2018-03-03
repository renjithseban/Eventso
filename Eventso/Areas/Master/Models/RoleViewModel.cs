using Evento.Models.Helper;

namespace Evento.Areas.Master.Models
{
    public class RoleViewModel : GenericProperties
    {
        public int RoleId { get; set; }

        public string RoleName { get; set; }
    }
}