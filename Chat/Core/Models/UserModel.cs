﻿namespace Chat.Core.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsMale { get; set; }
    }
}
