using System;
using System.Collections.Generic;
using System.Linq;
using BusinessEntities.Vendor;
using DataAccess.Helper;
using AutoMapper;
using DataAccess;

namespace BusinessService.Vendor
{
    public class TestimonialServices : ITestimonialServices
    {
        private readonly UnitOfWork unitOfWork;

        public TestimonialServices()
        {
        }

        public TestimonialServices(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    unitOfWork.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IEnumerable<TestimonialEntity> GetAllTestimonials()
        {
            try
            {
                var testimonials = unitOfWork.VendorTestimonialRepository.Get();
                if (testimonials != null)
                {
                    if (testimonials.Any())
                    {
                        var testimonialEntities = Mapper.Map<IEnumerable<Testimonial>, IEnumerable<TestimonialEntity>>(testimonials);
                        return testimonialEntities;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<TestimonialEntity> GetAllTestimonialsByVendorId(int vendorEntityId)
        {
            try
            {
                var testimonials = unitOfWork.VendorTestimonialRepository.GetMany(test => test.VendorId == vendorEntityId);
                if (testimonials != null)
                {
                    if (testimonials.Any())
                    {
                        var testimonialEntities = Mapper.Map<IEnumerable<Testimonial>, IEnumerable<TestimonialEntity>>(testimonials);
                        return testimonialEntities;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<TestimonialEntity> GetAllTestimonialsByVendorIdRating(int vendorEntityId, short rating)
        {
            try
            {
                var testimonials = unitOfWork.VendorTestimonialRepository.GetMany(test => test.VendorId == vendorEntityId && test.Rating == rating);
                if (testimonials != null)
                {
                    if (testimonials.Any())
                    {
                        var testimonialEntities = Mapper.Map<IEnumerable<Testimonial>, IEnumerable<TestimonialEntity>>(testimonials);
                        return testimonialEntities;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<TestimonialEntity> GetAllTestimonialsByRating(short rating)
        {
            try
            {
                var testimonials = unitOfWork.VendorTestimonialRepository.GetMany(test => test.Rating == rating);
                if (testimonials != null)
                {
                    if (testimonials.Any())
                    {
                        var testimonialEntities = Mapper.Map<IEnumerable<Testimonial>, IEnumerable<TestimonialEntity>>(testimonials);
                        return testimonialEntities;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<TestimonialEntity> GetAllTestimonialsByUserId(int userEntityId)
        {
            try
            {
                var testimonials = unitOfWork.VendorTestimonialRepository.GetMany(test => test.UserId == userEntityId);
                if (testimonials != null)
                {
                    if (testimonials.Any())
                    {
                        var testimonialEntities = Mapper.Map<IEnumerable<Testimonial>, IEnumerable<TestimonialEntity>>(testimonials);
                        return testimonialEntities;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int AddTestimonial(TestimonialEntity testimonialEntity)
        {
            try
            {
                var testimonial = Mapper.Map<TestimonialEntity, DataAccess.Testimonial>(testimonialEntity);
                var newVendorTestimonial = unitOfWork.VendorTestimonialRepository.Add(testimonial);
                unitOfWork.Save();
                if (newVendorTestimonial != null)
                    return newVendorTestimonial.TestimonialId;
                return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool UpdateTestimonial(TestimonialEntity testimonialEntity)
        {
            try
            {
                var testimonial = Mapper.Map<TestimonialEntity, DataAccess.Testimonial>(testimonialEntity);
                bool isEditted = unitOfWork.VendorTestimonialRepository.Update(testimonial);
                unitOfWork.Save();
                return isEditted;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DropTestimonial(int testimonialEntityId)
        {
            try
            {
                bool isDropped = unitOfWork.VendorTestimonialRepository.Remove(testimonialEntityId);
                unitOfWork.Save();
                return isDropped;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
