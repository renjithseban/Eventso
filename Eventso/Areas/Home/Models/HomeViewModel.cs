using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Evento.Areas.Home.Models
{
    public class HomeViewModel
    {
        public List<CategoryInfoViewModel> CategoryInfo { get; set; }

        public RegisterViewModel Register { get; set; }

        //public List<BestCrewsViewModel> BestCrews { get; set; }

        public ContactUsViewModel ContactUs { get; set; }
    }
}