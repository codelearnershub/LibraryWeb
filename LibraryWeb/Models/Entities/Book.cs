namespace LibraryWeb.Models.Entities
{
    public class Book : BaseEntity
    {
        public string BookTitle { get; set; }
        public string ISBN { get; set; }
        public string Categories { get; set; }
        public string Authors { get; set; }
        public string BookDescription { get; set; }
        public bool IsAvailable { get; set; }
    }
}
