﻿namespace AplicatieAdoptie.Domain.DTOs
{
    public class RegisterUserDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } = "User";
    }
}
