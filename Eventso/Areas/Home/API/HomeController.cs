using AutoMapper;
using BusinessService.Home;
using Evento.Areas.Home.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Evento.Areas.Home.API
{
    [RoutePrefix("api/Home")]
    public class HomeController : ApiController
    {
        readonly HomeServices homeServices;
        readonly BusinessService.Admin.UserServices userServices;

        public HomeController(HomeServices homeServices, BusinessService.Admin.UserServices userServices)
        {
            this.homeServices = homeServices;
            this.userServices = userServices;
        }

        [Route("Category")]
        // GET: api/Testimonials
        public IEnumerable<CategoryInfoViewModel> GetCategoryInfo()
        {
            var categoryInfoEntities = homeServices.GetCategoryInfo();
            if (categoryInfoEntities != null)
            {
                if (categoryInfoEntities.Any())
                {
                    Mapper.Initialize(cfg => { cfg.CreateMissingTypeMaps = true; cfg.CreateMap<BusinessEntities.Home.CategoryInfoEntity, CategoryInfoViewModel>(); });
                    var categoryInfo = Mapper.Map<IEnumerable<BusinessEntities.Home.CategoryInfoEntity>, IEnumerable<CategoryInfoViewModel>>(categoryInfoEntities);
                    return categoryInfo;
                }
            }
            return null;
        }

        [Route("TopFiveCrews")]
        // GET: api/Testimonials
        public IEnumerable<BestCrewsViewModel> GetTopFiveCrews()
        {
            var topFiveCrewEntities = homeServices.GetTopFiveCrews();
            if (topFiveCrewEntities != null)
            {
                if (topFiveCrewEntities.Any())
                {
                    Mapper.Initialize(cfg => { cfg.CreateMissingTypeMaps = true; cfg.CreateMap<BusinessEntities.Admin.CrewEntity, BestCrewsViewModel>(); });
                    var topFiveCrews = Mapper.Map<IEnumerable<BusinessEntities.Admin.CrewEntity>, IEnumerable<BestCrewsViewModel>>(topFiveCrewEntities);
                    return topFiveCrews;
                }
            }
            return null;
        }

        [Route("Add")]
        public int Post([FromBody]RegisterViewModel user)
        {
            if (user != null)
            {
                Mapper.Initialize(cfg => cfg.CreateMap<RegisterViewModel, BusinessEntities.Admin.UserEntity>());
                var userEntity = Mapper.Map<RegisterViewModel, BusinessEntities.Admin.UserEntity>(user);
                return userServices.AddUser(userEntity);
            }
            return 0;
        }
    }
}
