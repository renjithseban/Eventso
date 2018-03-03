using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using BusinessService.Master;
using BusinessEntities.Master;
using AutoMapper;

namespace EventsoServices.Controllers.Master
{
    [RoutePrefix("api/Admin/Categories")]
    public class CategoriesController : ApiController
    {
        readonly ICategoryServices categoryServices;

        public CategoriesController(CategoryServices categoryServices)
        {
            this.categoryServices = categoryServices;
        }

        [Route("")]
        // GET: api/Categories
        public IEnumerable<CategoryEntity> GetAllCategories()
        {
            var categoryEntities = categoryServices.GetAllCategories();
            if (categoryEntities != null)
            {
                if (categoryEntities.Any())
                {
                    return categoryEntities;
                }
            }
            return null;
        }

        [Route("{id}")]
        // GET: api/Categories/5
        public CategoryEntity Get(int id)
        {
            var categoryEntity = categoryServices.GetCategoryById(id);
            if (categoryEntity != null)
            {
                return categoryEntity;
            }
            return null;
        }

        [Route("Find/{categoryName}")]
        // GET: api/Admin/Districts/Find/Ernakulam
        public CategoryEntity Get(string categoryName)
        {
            var categoryEntity = categoryServices.GetCategoryByName(categoryName);
            if (categoryEntity != null)
            {
                return categoryEntity;
            }
            return null;
        }

        // POST: api/Categories
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Categories/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Categories/5
        public void Delete(int id)
        {
        }
    }
}
