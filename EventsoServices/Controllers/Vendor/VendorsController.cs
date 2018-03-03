using AutoMapper;
using BusinessEntities.Vendor;
using BusinessService.Vendor;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace EventsoServices.Controllers.Vendor
{
    [RoutePrefix("api/Admin/Vendors")]
    public class VendorsController : ApiController
    {
        readonly IVendorServices crewServices;
        public VendorsController(VendorServices crewServices)
        {
            this.crewServices = crewServices;
        }

        [Route("")]
        // GET: api/Vendors
        public IEnumerable<VendorEntity> GetAllVendors()
        {
            var crewEntities = crewServices.GetAllVendors();
            if (crewEntities != null)
            {
                if (crewEntities.Any())
                {
                    //Mapper.Initialize(cfg => { cfg.CreateMissingTypeMaps = true; cfg.CreateMap<VendorEntity, VendorViewModel>(); });
                    //var crews = Mapper.Map<IEnumerable<VendorEntity>, IEnumerable<VendorViewModel>>(crewEntities);
                    //return crews;
                    return crewEntities;
                }
            }
            return null;
        }

        [Route("{id}")]
        // GET: api/Vendors/5
        public VendorEntity Get(int id)
        {
            var crewEntity = crewServices.GetVendorById(id);
            if (crewEntity != null)
            {
                //Mapper.Initialize(cfg => { cfg.CreateMissingTypeMaps = true; cfg.CreateMap<VendorEntity, VendorViewModel>(); });
                //var crew = Mapper.Map<VendorEntity, VendorViewModel>(crewEntity);
                return crewEntity;
            }
            return null;
        }

        // POST: api/Vendors
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Vendors/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Vendors/5
        public void Delete(int id)
        {
        }
    }
}
