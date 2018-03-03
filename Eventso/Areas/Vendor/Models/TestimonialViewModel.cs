using Evento.Models.Helper;

namespace Evento.Areas.Vendor.Models
{
    public class TestimonialViewModel : GenericProperties
    {
        public int VendorTestimonialId { get; set; }

        public int VendorId { get; set; }

        public string VendorName { get; set; }

        public string Testimonial { get; set; }

        private string FirstName { get; set; }

        private string LastName { get; set; }

        public string TestimonialUser
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public short Rating { get; set; }

        public bool IsGenuine { get; set; }

        public string ImageFolderPath { get; set; }

    }
}