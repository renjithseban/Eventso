using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Evento.Models.Helper
{
    public class Enums
    {
        public enum SignInStatus
        {
            Success,
            LockedOut,
            RequiresVerification,
            Failure
        }
    }
}