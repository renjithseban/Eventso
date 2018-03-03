using AutoMapper;
using BusinessEntities.Admin;
using BusinessService.Admin;
using Evento.Areas.Admin.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Evento.Areas.Admin.API
{
    [RoutePrefix("api/Admin/Districts")]
    public class DistrictsController : ApiController
    {
        readonly IDistrictServices districtServices;

        public DistrictsController(DistrictServices districtServices)
        {
            this.districtServices = districtServices;
        }

        [Route("")]
        // GET: api/Admin/Districts
        public IEnumerable<DistrictViewModel> GetAllDistricts()

        {
            var districtEntities = districtServices.GetAllDistricts();
            if (districtEntities != null)
            {
                if (districtEntities.Any())
                {
                    Mapper.Initialize(cfg => { cfg.CreateMissingTypeMaps = true; cfg.CreateMap<DistrictEntity, DistrictViewModel>(); });
                    var districts = Mapper.Map<IEnumerable<DistrictEntity>, IEnumerable<DistrictViewModel>>(districtEntities);
                    return districts;
                }
            }
            return null;
        }

        [Route("{id}")]
        // GET: api/Admin/Districts/5
        public DistrictViewModel Get(int id)
        {
            var districtEntity = districtServices.GetDistrictById(id);
            if (districtEntity != null)
            {
                Mapper.Initialize(cfg => { cfg.CreateMissingTypeMaps = true; cfg.CreateMap<DistrictEntity, DistrictViewModel>(); });
                var district = Mapper.Map<DistrictEntity, DistrictViewModel>(districtEntity);
                return district;
            }
            return null;
        }


        [Route("Find/{districtName}")]
        // GET: api/Admin/Districts/Find/Ernakulam
        public DistrictViewModel Get(string districtName)
        {
            var districtEntity = districtServices.GetDistrictByName(districtName);
            if (districtEntity != null)
            {
                Mapper.Initialize(cfg => { cfg.CreateMissingTypeMaps = true; cfg.CreateMap<DistrictEntity, DistrictViewModel>(); });
                var district = Mapper.Map<DistrictEntity, DistrictViewModel>(districtEntity);
                return district;
            }
            return null;
        }
        [HttpGet]
        [Route("State/Find/{stateName}")]
        // GET: api/Admin/Districts/State/Find/Kerala
        public IEnumerable<DistrictViewModel> Find(string stateName)
        {
            var districtEntity = districtServices.GetDistrictByStateName(stateName);
            if (districtEntity != null)
            {
                Mapper.Initialize(cfg => { cfg.CreateMissingTypeMaps = true; cfg.CreateMap<DistrictEntity, DistrictViewModel>(); });
                var district = Mapper.Map<IEnumerable<DistrictEntity>, IEnumerable<DistrictViewModel>>(districtEntity);
                return district;
            }
            return null;
        }
        [HttpGet]
        [Route("State/{id}")]
        // GET: api/Admin/Districts/State/5
        public IEnumerable<DistrictViewModel> Find(int id)
        {
            var districtEntity = districtServices.GetDistrictByStateId(id);
            if (districtEntity != null)
            {
                Mapper.Initialize(cfg => { cfg.CreateMissingTypeMaps = true; cfg.CreateMap<DistrictEntity, DistrictViewModel>(); });
                var district = Mapper.Map<IEnumerable<DistrictEntity>, IEnumerable<DistrictViewModel>>(districtEntity);
                return district;
            }
            return null;
        }

        // POST: api/Districts
        public int Post([FromBody]StateViewModel state)
        {
            return 1;
        }

        // PUT: api/Districts/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Districts/5
        public void Delete(int id)
        {
        }
    }
}
