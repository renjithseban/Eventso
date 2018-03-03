using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.Vendor;

namespace BusinessService.Vendor
{
    public interface ITestimonialServices : IDisposable
    {
        IEnumerable<TestimonialEntity> GetAllTestimonials();

        IEnumerable<TestimonialEntity> GetAllTestimonialsByVendorId(int vendorEntityId);

        IEnumerable<TestimonialEntity> GetAllTestimonialsByUserId(int userEntityId);

        IEnumerable<TestimonialEntity> GetAllTestimonialsByRating(short rating);

        IEnumerable<TestimonialEntity> GetAllTestimonialsByVendorIdRating(int vendorEntityId, short rating);

        int AddTestimonial(TestimonialEntity testimonialEntity);

        bool UpdateTestimonial(TestimonialEntity testimonialEntity);

        bool DropTestimonial(int testimonialEntityId);

    }
}
