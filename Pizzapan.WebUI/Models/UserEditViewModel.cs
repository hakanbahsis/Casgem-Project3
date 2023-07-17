﻿namespace Pizzapan.WebUI.Models
{
    public class UserEditViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Mail { get; set; }
        public string City { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
    }
}
