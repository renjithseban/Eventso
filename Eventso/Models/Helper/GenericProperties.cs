using System;
using System.ComponentModel;

namespace Evento.Models.Helper
{
    public class GenericProperties
    {
        [DisplayName("Created By")]
        public int? CreatedBy { get; set; }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate { get; set; }

        [DisplayName("Updated By")]
        public int? UpdatedBy { get; set; }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate { get; set; }

        [DisplayName("Active")]
        public bool IsActive { get; set; }
    }
}