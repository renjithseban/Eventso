using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Evento.Areas.Home.Models
{
    public class BestCrewsViewModel
    {
        public int CrewId { get; set; }

        public string CrewName { get; set; }

        public string CrewEmail { get; set; }

        public string CrewContactNo { get; set; }

        public Uri CrewWebsiteURI { get; set; }

        public Uri CrewFacebook { get; set; }

        public Uri CrewTwitter { get; set; }

        public string CrewDescription { get; set; }

        public string AlternateContactNo { get; set; }
    }
}