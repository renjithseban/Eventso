using System;

namespace BusinessEntities.Helper
{
    public class GenericProperties
    {
        public int? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool IsActive { get; set; }
    }
}
