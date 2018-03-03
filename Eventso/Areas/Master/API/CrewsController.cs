using AutoMapper;
using BusinessEntities.Admin;
using BusinessService.Admin;
using Evento.Areas.Admin.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Evento.Areas.Admin.API
{
    [RoutePrefix("api/Admin/Crews")]
    public class CrewsController : ApiController
    {
        readonly ICrewServices crewServices;
        public CrewsController(CrewServices crewServices)
        {
            this.crewServices = crewServices;
        }

        [Route("")]
        // GET: api/Crews
        public IEnumerable<CrewViewModel> GetAllCrews()
        {
            var crewEntities = crewServices.GetAllCrews();
            if (crewEntities != null)
            {
                if (crewEntities.Any())
                {
                    Mapper.Initialize(cfg => { cfg.CreateMissingTypeMaps = true; cfg.CreateMap<CrewEntity, CrewViewModel>(); });
                    var crews = Mapper.Map<IEnumerable<CrewEntity>, IEnumerable<CrewViewModel>>(crewEntities);
                    return crews;
                }
            }
            return null;
        }

        [Route("{id}")]
        // GET: api/Crews/5
        public CrewViewModel Get(int id)
        {
            var crewEntity = crewServices.GetCrewById(id);
            if (crewEntity != null)
            {
                Mapper.Initialize(cfg => { cfg.CreateMissingTypeMaps = true; cfg.CreateMap<CrewEntity, CrewViewModel>(); });
                var crew = Mapper.Map<CrewEntity, CrewViewModel>(crewEntity);
                return crew;
            }
            return null;
        }

        // POST: api/Crews
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Crews/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Crews/5
        public void Delete(int id)
        {
        }
    }
}
