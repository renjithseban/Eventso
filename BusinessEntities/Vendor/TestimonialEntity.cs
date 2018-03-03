using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Vendor
{
    public class TestimonialEntity : Helper.GenericProperties
    {
        public int VendorTestimonialId { get; set; }

        public VendorEntity Vendor { get; set; }

        public string Testimonial { get; set; }

        public Common.UserEntity TestimonialUser { get; set; }

        public short Rating { get; set; }

        public bool IsGenuine { get; set; }

        public string ImageFolderPath { get; set; }
    }
}
