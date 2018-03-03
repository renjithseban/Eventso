using System;

namespace BusinessEntities.Vendor
{
    public class ViewershipEntity : Helper.GenericProperties
    {
        public int ViewershipId { get; set; }

        public VendorEntity Vendor { get; set; }

        public DateTime ViewedDate { get; set; }

        public Common.UserEntity ViewedUser { get; set; }

        public bool HasSentMail { get; set; }

        public bool HasSentSMS { get; set; }
    }
}
