using System.Web.Mvc;

namespace Evento.Areas.Crew
{
    public class CrewAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Crew";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Crew_default",
                "Crew/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}