using AutoMapper;
using DataAccess;

namespace BusinessService.Helper
{
    public static class AutoMapperConfigBusiness
    {
        public static void Initialise()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<User, BusinessEntities.Common.UserEntity>();
                cfg.CreateMap<BusinessEntities.Common.UserEntity, User>();
                cfg.CreateMap<State, BusinessEntities.Master.StateEntity>();
                cfg.CreateMap<BusinessEntities.Master.StateEntity, State>();
                cfg.CreateMap<Category, BusinessEntities.Master.CategoryEntity>();
                cfg.CreateMap<BusinessEntities.Master.DistrictEntity, District>();
                cfg.CreateMap<District, BusinessEntities.Master.DistrictEntity>();
                cfg.CreateMap<BusinessEntities.Master.RoleEntity, Role>();
                cfg.CreateMap<Role, BusinessEntities.Master.RoleEntity>();
                cfg.CreateMap<BusinessEntities.Vendor.OfficeAddressEntity, OfficeAddress>();
                cfg.CreateMap<OfficeAddress, BusinessEntities.Vendor.OfficeAddressEntity>();
                cfg.CreateMap<Testimonial, BusinessEntities.Vendor.TestimonialEntity>();
                cfg.CreateMap<BusinessEntities.Vendor.TestimonialEntity, Testimonial>();
                cfg.CreateMap<BusinessEntities.Vendor.VendorCategoryEntity, VendorCategory>();
                cfg.CreateMap<VendorCategory, BusinessEntities.Vendor.VendorCategoryEntity>();
                cfg.CreateMap<DataAccess.Vendor, BusinessEntities.Vendor.VendorEntity>();
                cfg.CreateMap<BusinessEntities.Vendor.ViewershipEntity, Viewership>();
                cfg.CreateMap<Viewership, BusinessEntities.Vendor.ViewershipEntity>();
            });
        }
    }

}