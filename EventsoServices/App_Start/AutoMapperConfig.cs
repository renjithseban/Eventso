using BusinessService.Helper;

namespace EventsoServices.App_Start
{
    public class AutoMapperConfig
    {
        public static void Initialise()
        {
            AutoMapperConfigBusiness.Initialise();
        }
    }
}