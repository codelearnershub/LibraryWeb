namespace LibraryWeb.Models.Entities
{
    public class Libarian : BaseEntity
    {
        public string StaffNumber { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
