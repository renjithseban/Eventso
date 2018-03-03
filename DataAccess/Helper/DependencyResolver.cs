using Resolver;
using System.ComponentModel.Composition;

namespace DataAccess.Helper
{
    [Export(typeof(IComponent))]
    public class DependencyResolver : IComponent
    {
        public void SetUp(IRegisterComponent registerComponent)
        {
            registerComponent.RegisterType<IUnitOfWork, UnitOfWork>();
        }
    }
}

