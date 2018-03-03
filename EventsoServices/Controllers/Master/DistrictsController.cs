using AutoMapper;
using BusinessEntities.Master;
using BusinessService.Master;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace EventsoServices.Controllers.Master
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
        public IEnumerable<DistrictEntity> GetAllDistricts()

        {
            var districtEntities = districtServices.GetAllDistricts();
            if (districtEntities != null)
            {
                if (districtEntities.Any())
                {
                    //Mapper.Initialize(cfg => { cfg.CreateMissingTypeMaps = true; cfg.CreateMap<DistrictEntity, DistrictViewModel>(); });
                    //var districts = Mapper.Map<IEnumerable<DistrictEntity>, IEnumerable<DistrictViewModel>>(districtEntities);
                    return districtEntities;
                }
            }
            return null;
        }

        [Route("{id}")]
        // GET: api/Admin/Districts/5
        public DistrictEntity Get(int id)
        {
            var districtEntity = districtServices.GetDistrictById(id);
            if (districtEntity != null)
            {
                //Mapper.Initialize(cfg => { cfg.CreateMissingTypeMaps = true; cfg.CreateMap<DistrictEntity, DistrictViewModel>(); });
                //var district = Mapper.Map<DistrictEntity, DistrictViewModel>(districtEntity);
                return districtEntity;
            }
            return null;
        }


        [Route("Find/{districtName}")]
        // GET: api/Admin/Districts/Find/Ernakulam
        public DistrictEntity Get(string districtName)
        {
            var districtEntity = districtServices.GetDistrictByName(districtName);
            if (districtEntity != null)
            {
                //Mapper.Initialize(cfg => { cfg.CreateMissingTypeMaps = true; cfg.CreateMap<DistrictEntity, DistrictViewModel>(); });
                //var district = Mapper.Map<DistrictEntity, DistrictViewModel>(districtEntity);
                return districtEntity;
            }
            return null;
        }
        [HttpGet]
        [Route("State/Find/{stateName}")]
        // GET: api/Admin/Districts/State/Find/Kerala
        public IEnumerable<DistrictEntity> Find(string stateName)
        {
            var districtEntity = districtServices.GetDistrictByStateName(stateName);
            if (districtEntity != null)
            {
                //Mapper.Initialize(cfg => { cfg.CreateMissingTypeMaps = true; cfg.CreateMap<DistrictEntity, DistrictViewModel>(); });
                //var district = Mapper.Map<IEnumerable<DistrictEntity>, IEnumerable<DistrictViewModel>>(districtEntity);
                return districtEntity;
            }
            return null;
        }
        [HttpGet]
        [Route("State/{id}")]
        // GET: api/Admin/Districts/State/5
        public IEnumerable<DistrictEntity> Find(int id)
        {
            var districtEntity = districtServices.GetDistrictByStateId(id);
            if (districtEntity != null)
            {
                //Mapper.Initialize(cfg => { cfg.CreateMissingTypeMaps = true; cfg.CreateMap<DistrictEntity, DistrictViewModel>(); });
                //var district = Mapper.Map<IEnumerable<DistrictEntity>, IEnumerable<DistrictViewModel>>(districtEntity);
                return districtEntity;
            }
            return null;
        }

        // POST: api/Districts
        public int Post([FromBody]DistrictEntity state)
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
