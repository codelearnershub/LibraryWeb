using LibraryWeb.Models.Enums;

namespace LibraryWeb.Models.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RoleName { get; set; }
        public Gender Gender { get; set; }

    }
}
