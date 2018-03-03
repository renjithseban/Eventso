using BusinessEntities.Master;
using BusinessService.Master;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace EventsoServices.Controllers.Master
{
    public class CategoryFiltersController : ApiController
    {
        readonly ICategoryFilterServices categoryFilterServices;

        public CategoryFiltersController(CategoryFilterServices categoryFilterServices)
        {
            this.categoryFilterServices = categoryFilterServices;
        }

        [Route("")]
        // GET: api/CategoryFilters
        public IEnumerable<CategoryFilterEntity> GetAllCategoryFilters()
        {
            var categoryFilterEntities = categoryFilterServices.GetAllCategoryFilters();
            if (categoryFilterEntities != null)
            {
                if (categoryFilterEntities.Any())
                {
                    return categoryFilterEntities;
                }
            }
            return null;
        }

        // GET: api/CategoryFilters/5
        [Route("{categoryId}")]
        public IEnumerable<CategoryFilterEntity> Get(int categoryId)
        {
            var categoryFilterEntity = categoryFilterServices.GetCategoryFilterByCategoryId(categoryId);
            if (categoryFilterEntity != null)
            {
                return categoryFilterEntity;
            }
            return null;
        }

        // POST: api/CategoryFilters
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CategoryFilters/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CategoryFilters/5
        public void Delete(int id)
        {
        }
    }
}
