﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Evento.Areas.Home.Models
{
    public class ContactUsViewModel
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }
    }
}