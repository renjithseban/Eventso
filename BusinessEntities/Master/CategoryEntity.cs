namespace BusinessEntities.Master
{
    public class CategoryEntity : Helper.GenericProperties
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public CategoryEntity ParentCategory { get; set; }
    }
}
