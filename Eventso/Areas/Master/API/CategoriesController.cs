using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using BusinessService.Admin;
using Evento.Areas.Admin.Models;
using BusinessEntities.Admin;
using AutoMapper;

namespace Evento.Areas.Admin.API
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
        public IEnumerable<CategoryViewModel> GetAllCategories()
        {
            var categoryEntities = categoryServices.GetAllCategories();
            if (categoryEntities != null)
            {
                if (categoryEntities.Any())
                {
                    Mapper.Initialize(cfg => { cfg.CreateMissingTypeMaps = true; cfg.CreateMap<CategoryEntity, CategoryViewModel>(); });
                    var categories = Mapper.Map<IEnumerable<CategoryEntity>, IEnumerable<CategoryViewModel>>(categoryEntities);
                    return categories;
                }
            }
            return null;
        }

        [Route("{id}")]
        // GET: api/Categories/5
        public CategoryViewModel Get(int id)
        {
            var categoryEntity = categoryServices.GetCategoryById(id);
            if (categoryEntity != null)
            {
                Mapper.Initialize(cfg => { cfg.CreateMissingTypeMaps = true; cfg.CreateMap<CategoryEntity, CategoryViewModel>(); });
                var category = Mapper.Map<CategoryEntity, CategoryViewModel>(categoryEntity);
                return category;
            }
            return null;
        }

        [Route("Find/{categoryName}")]
        // GET: api/Admin/Districts/Find/Ernakulam
        public CategoryViewModel Get(string categoryName)
        {
            var categoryEntity = categoryServices.GetCategoryByName(categoryName);
            if (categoryEntity != null)
            {
                Mapper.Initialize(cfg => { cfg.CreateMissingTypeMaps = true; cfg.CreateMap<CategoryEntity, CategoryViewModel>(); });
                var category = Mapper.Map<CategoryEntity, CategoryViewModel>(categoryEntity);
                return category;
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
