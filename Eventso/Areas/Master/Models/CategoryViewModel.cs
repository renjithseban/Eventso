using Evento.Models.Helper;

namespace Evento.Areas.Master.Models
{
    public class CategoryViewModel : GenericProperties
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public CategoryViewModel ParentCategory { get; set; }

    }
}