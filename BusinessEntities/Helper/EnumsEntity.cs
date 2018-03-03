using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Helper
{
    public class EnumsEntity
    {
        public enum SignInStatusEntity
        {
            Success,
            LockedOut,
            RequiresVerification,
            Failure
        }
    }
}
