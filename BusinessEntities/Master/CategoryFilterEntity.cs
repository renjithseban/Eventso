namespace BusinessEntities.Master
{
    public class CategoryFilterEntity
    {
        public int CategoryFilterId { get; set; }

        public string FilterName { get; set; }

        public CategoryEntity FilterCategory { get; set; }
    }
}
