using AutoMapper;
using BusinessEntities.Crew;
using BusinessService.Crew;
using Evento.Areas.Crew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Evento.Areas.Crew.API
{
    [RoutePrefix("api/Crew/Testimonials")]
    public class TestimonialsController : ApiController
    {
        readonly ITestimonialServices testimonialServices;

        public TestimonialsController(TestimonialServices testimonialServices)
        {
            this.testimonialServices = testimonialServices;
        }

        [Route("")]
        // GET: api/Testimonials
        public IEnumerable<TestimonialViewModel> GetAllTestimonials()
        {
            var testimonialEntities = testimonialServices.GetAllTestimonials();
            if (testimonialEntities != null)
            {
                if (testimonialEntities.Any())
                {
                    Mapper.Initialize(cfg => { cfg.CreateMissingTypeMaps = true; cfg.CreateMap<TestimonialEntity, TestimonialViewModel>(); });
                    var testimonials = Mapper.Map<IEnumerable<TestimonialEntity>, IEnumerable<TestimonialViewModel>>(testimonialEntities);
                    return testimonials;
                }
            }
            return null;
        }

        [Route("Crew/{id}")]
        // GET: api/Testimonials/Crew/1
        public IEnumerable<TestimonialViewModel> GetAllTestimonialsByCrewId(int crewId)
        {
            var testimonialEntities = testimonialServices.GetAllTestimonialsByCrewId(crewId);
            if (testimonialEntities != null)
            {
                if (testimonialEntities.Any())
                {
                    Mapper.Initialize(cfg => { cfg.CreateMissingTypeMaps = true; cfg.CreateMap<TestimonialEntity, TestimonialViewModel>(); });
                    var testimonials = Mapper.Map<IEnumerable<TestimonialEntity>, IEnumerable<TestimonialViewModel>>(testimonialEntities);
                    return testimonials;
                }
            }
            return null;
        }

        [Route("User/{id}")]
        // GET: api/Testimonials/Crew/1
        public IEnumerable<TestimonialViewModel> GetAllTestimonialsByUserId(int userId)
        {
            var testimonialEntities = testimonialServices.GetAllTestimonialsByUserId(userId);
            if (testimonialEntities != null)
            {
                if (testimonialEntities.Any())
                {
                    Mapper.Initialize(cfg => { cfg.CreateMissingTypeMaps = true; cfg.CreateMap<TestimonialEntity, TestimonialViewModel>(); });
                    var testimonials = Mapper.Map<IEnumerable<TestimonialEntity>, IEnumerable<TestimonialViewModel>>(testimonialEntities);
                    return testimonials;
                }
            }
            return null;
        }

        [Route("Rating/{value}")]
        // GET: api/Testimonials/Crew/1
        public IEnumerable<TestimonialViewModel> GetAllTestimonialsByRating(short value)
        {
            var testimonialEntities = testimonialServices.GetAllTestimonialsByRating(value);
            if (testimonialEntities != null)
            {
                if (testimonialEntities.Any())
                {
                    Mapper.Initialize(cfg => { cfg.CreateMissingTypeMaps = true; cfg.CreateMap<TestimonialEntity, TestimonialViewModel>(); });
                    var testimonials = Mapper.Map<IEnumerable<TestimonialEntity>, IEnumerable<TestimonialViewModel>>(testimonialEntities);
                    return testimonials;
                }
            }
            return null;
        }

        [Route("Crew/{id}/Rating/{value}")]
        // GET: api/Testimonials/Crew/1
        public IEnumerable<TestimonialViewModel> GetAllTestimonialsByCrewIdRating(int crewId, short value)
        {
            var testimonialEntities = testimonialServices.GetAllTestimonialsByCrewIdRating(crewId, value);
            if (testimonialEntities != null)
            {
                if (testimonialEntities.Any())
                {
                    Mapper.Initialize(cfg => { cfg.CreateMissingTypeMaps = true; cfg.CreateMap<TestimonialEntity, TestimonialViewModel>(); });
                    var testimonials = Mapper.Map<IEnumerable<TestimonialEntity>, IEnumerable<TestimonialViewModel>>(testimonialEntities);
                    return testimonials;
                }
            }
            return null;
        }

        [Route("Add")]
        // POST: api/Testimonials
        public int Post([FromBody]TestimonialViewModel testimonial)
        {
            if (testimonial != null)
            {
                Mapper.Initialize(cfg => cfg.CreateMap<TestimonialViewModel, TestimonialEntity>());
                var testimonialEntity = Mapper.Map<TestimonialViewModel, TestimonialEntity>(testimonial);
                return testimonialServices.AddTestimonial(testimonialEntity);
            }
            return 0;
        }

        // PUT: api/Testimonials/5
        [Route("Update")]
        public bool Put([FromBody]TestimonialViewModel testimonial)
        {
            if (testimonial != null)
            {
                Mapper.Initialize(cfg => cfg.CreateMap<TestimonialViewModel, TestimonialEntity>());
                var testimonialEntity = Mapper.Map<TestimonialViewModel, TestimonialEntity>(testimonial);
                return testimonialServices.UpdateTestimonial(testimonialEntity);
            }
            return false;
        }

        [Route("Drop/{testimonialId}")]
        // DELETE: api/Testimonials/5
        public void Delete(int testimonialId)
        {
            try
            {
                if (testimonialId > 0)
                {
                    testimonialServices.DropTestimonial(testimonialId);
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
