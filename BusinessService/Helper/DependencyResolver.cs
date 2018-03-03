using BusinessService;
using Resolver;
using System.ComponentModel.Composition;

namespace BusinessService.Helper
{
    [Export(typeof(IComponent))]
    public class DependencyResolver : IComponent
    {
        public void SetUp(IRegisterComponent registerComponent)
        {
            registerComponent.RegisterType<Master.IStateServices, Master.StateServices>();
            registerComponent.RegisterType<Master.IDistrictServices, Master.DistrictServices>();
            registerComponent.RegisterType<Common.IUserServices, Common.UserServices>();
            registerComponent.RegisterType<Master.IRoleServices, Master.RoleServices>();
            registerComponent.RegisterType<Master.ICategoryServices, Master.CategoryServices>();
            registerComponent.RegisterType<Vendor.IVendorServices, Vendor.VendorServices>();
        }
    }
}
