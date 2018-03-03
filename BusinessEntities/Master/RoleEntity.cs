using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Master
{
    public class RoleEntity : Helper.GenericProperties
    {
        public int RoleId { get; set; }

        public string RoleName { get; set; }

    }
}
