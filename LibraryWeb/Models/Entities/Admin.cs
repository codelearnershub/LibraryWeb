﻿namespace LibraryWeb.Models.Entities
{
    public class Admin : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
