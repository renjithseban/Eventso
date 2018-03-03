using AutoMapper;
using BusinessEntities.Crew;
using BusinessService.Crew;
using Evento.Areas.Crew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Evento.Areas.Crew.API
{
    [RoutePrefix("api/Crew/OfficeAddresses")]
    public class OfficeAddressesController : ApiController
    {
        readonly IOfficeAddressServices officeAddressServices;

        public OfficeAddressesController(OfficeAddressServices officeAddressServices)
        {
            this.officeAddressServices = officeAddressServices;
        }

        [Route("Crew/{crewId}")]
        // GET: api/Testimonials/Crew/1
        public IEnumerable<OfficeAddressViewModel> GetAllOfficeAddressByCrewId(int crewId)
        {
            var officeAddressEntities = officeAddressServices.GetAllOfficeAddressByCrewId(crewId);
            if (officeAddressEntities != null)
            {
                if (officeAddressEntities.Any())
                {
                    Mapper.Initialize(cfg => { cfg.CreateMissingTypeMaps = true; cfg.CreateMap<OfficeAddressEntity, OfficeAddressViewModel>(); });
                    var officeAddresses = Mapper.Map<IEnumerable<OfficeAddressEntity>, IEnumerable<OfficeAddressViewModel>>(officeAddressEntities);
                    return officeAddresses;
                }
            }
            return null;
        }

        [Route("District/{districtId}")]
        // GET: api/Testimonials/Crew/1
        public IEnumerable<OfficeAddressViewModel> GetAllOfficeAddressByDistrictId(int districtId)
        {
            var officeAddressEntities = officeAddressServices.GetAllOfficeAddressByDistrictId(districtId);
            if (officeAddressEntities != null)
            {
                if (officeAddressEntities.Any())
                {
                    Mapper.Initialize(cfg => { cfg.CreateMissingTypeMaps = true; cfg.CreateMap<OfficeAddressEntity, OfficeAddressViewModel>(); });
                    var officeAddresses = Mapper.Map<IEnumerable<OfficeAddressEntity>, IEnumerable<OfficeAddressViewModel>>(officeAddressEntities);
                    return officeAddresses;
                }
            }
            return null;
        }

        [Route("Location/{location}")]
        // GET: api/Testimonials/Crew/1
        public IEnumerable<OfficeAddressViewModel> GetAllOfficeAddressByLocation(string location)
        {
            var officeAddressEntities = officeAddressServices.GetAllOfficeAddressByLocation(location);
            if (officeAddressEntities != null)
            {
                if (officeAddressEntities.Any())
                {
                    Mapper.Initialize(cfg => { cfg.CreateMissingTypeMaps = true; cfg.CreateMap<OfficeAddressEntity, OfficeAddressViewModel>(); });
                    var officeAddresses = Mapper.Map<IEnumerable<OfficeAddressEntity>, IEnumerable<OfficeAddressViewModel>>(officeAddressEntities);
                    return officeAddresses;
                }
            }
            return null;
        }

        [Route("State/{stateId}")]
        // GET: api/Testimonials/Crew/1
        public IEnumerable<OfficeAddressViewModel> GetAllOfficeAddressByStateId(int stateId)
        {
            var officeAddressEntities = officeAddressServices.GetAllOfficeAddressByStateId(stateId);
            if (officeAddressEntities != null)
            {
                if (officeAddressEntities.Any())
                {
                    Mapper.Initialize(cfg => { cfg.CreateMissingTypeMaps = true; cfg.CreateMap<OfficeAddressEntity, OfficeAddressViewModel>(); });
                    var officeAddresses = Mapper.Map<IEnumerable<OfficeAddressEntity>, IEnumerable<OfficeAddressViewModel>>(officeAddressEntities);
                    return officeAddresses;
                }
            }
            return null;
        }

        [Route("Add")]
        // POST: api/Testimonials
        public int Post([FromBody]OfficeAddressViewModel officeAddress)
        {
            if (officeAddress != null)
            {
                Mapper.Initialize(cfg => cfg.CreateMap<OfficeAddressViewModel, OfficeAddressEntity>());
                var officeAddressEntity = Mapper.Map<OfficeAddressViewModel, OfficeAddressEntity>(officeAddress);
                return officeAddressServices.AddOfficeAddress(officeAddressEntity);
            }
            return 0;
        }

        // PUT: api/Testimonials/5
        [Route("Update")]
        public bool Put([FromBody]OfficeAddressViewModel officeAddress)
        {
            if (officeAddress != null)
            {
                Mapper.Initialize(cfg => cfg.CreateMap<OfficeAddressViewModel, OfficeAddressEntity>());
                var officeAddressEntity = Mapper.Map<OfficeAddressViewModel, OfficeAddressEntity>(officeAddress);
                return officeAddressServices.UpdateOfficeAddress(officeAddressEntity);
            }
            return false;
        }

        [Route("Drop/{officeAddressId}")]
        // DELETE: api/Testimonials/5
        public void Delete(int officeAddressId)
        {
            try
            {
                if (officeAddressId > 0)
                {
                    officeAddressServices.DropOfficeAddress(officeAddressId);
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
