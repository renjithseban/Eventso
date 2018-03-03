using System;
using System.Collections.Generic;
using BusinessEntities.Home;
using DataAccess.Helper;
using AutoMapper;
using System.Linq;
using BusinessEntities.Admin;

namespace BusinessService.Home
{
    public class HomeServices : IHomeServices
    {
        private readonly UnitOfWork unitOfWork;

        public HomeServices()
        {
        }

        public HomeServices(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    unitOfWork.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IEnumerable<CategoryInfoEntity> GetCategoryInfo()
        {
            try
            {
                Mapper.Initialize(cfg => cfg.CreateMap<DataAccess.CrewCategory, BusinessEntities.Crew.CrewCategoryEntity>());
                var crewCategories = unitOfWork.CrewCategoryRepository.Get();
                if (crewCategories != null)
                {
                    if (crewCategories.Any())
                    {
                        var crewCategoryEntities = Mapper.Map<IEnumerable<DataAccess.CrewCategory>, IEnumerable<BusinessEntities.Crew.CrewCategoryEntity>>(crewCategories);
                        var categoryInfoGroups = crewCategoryEntities.Where(cc => cc.Category.IsActive == true && cc.Crew.IsActive == true)
                                                                .GroupBy(cc => new { cc.Category.CategoryId, cc.Category.CategoryName, cc.Category.CategoryDescription })
                                                                .Select(c => new { CategoryId = c.Key.CategoryId, CategoryName = c.Key.CategoryName, CategoryDescription = c.Key.CategoryDescription, CrewCount = c.Count() });

                        return (IEnumerable<CategoryInfoEntity>)categoryInfoGroups;

                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<CrewEntity> GetTopFiveCrews()
        {
            try
            {
                Mapper.Initialize(cfg => cfg.CreateMap<DataAccess.TopFiveCrew, CrewEntity>());
                var topCrews = unitOfWork.TopCrewRepository.Get().OrderByDescending(tc => tc.NetScore).Take(5);
                if (topCrews != null)
                {
                    if (topCrews.Any())
                    {
                        var crewEntities = Mapper.Map<IEnumerable<DataAccess.TopFiveCrew>, IEnumerable<CrewEntity>>(topCrews);
                        return crewEntities;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
