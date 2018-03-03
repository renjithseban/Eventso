namespace BusinessEntities.Common
{
    public class UserEntity : Helper.GenericProperties
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserEmail { get; set; }

        public string Password { get; set; }

        public string ContactNo { get; set; }

        public bool IsEmailVerfied { get; set; }

        public bool IsMobileVerified { get; set; }

        public bool IsLockedOut { get; set; }
    }
}
