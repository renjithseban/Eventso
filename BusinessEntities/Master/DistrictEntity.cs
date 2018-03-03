namespace BusinessEntities.Master
{
    public class DistrictEntity : Helper.GenericProperties
    {
        public int DistrictId { get; set; }
        public string DistrictName { get; set; }
        //public int StateId { get; set; }

        public StateEntity State { get; set; }
    }
}
