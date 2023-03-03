using LibraryWeb.Models.Enums;

namespace LibraryWeb.Models.Entities
{
    public class LibraryUser : BaseEntity
    {
        public string UserNumber { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public LibraryUser AddLibraryUser (int userId)
        {
            UserId = userId;
            UserNumber = GenerateUserNumber();
            return this;
        }

        private string GenerateUserNumber()
        {
            Random random = new Random();
            var userNumber = $"LIB{random.Next(999, 10000)}";
            return userNumber;
        }
    }
}
