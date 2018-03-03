using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Master
{
    public class CategoryFilterEntity
    {
        public int CategoryFilterId { get; set; }

        public string FilterName { get; set; }

        public CategoryEntity FilterCategory { get; set; }
    }
}
