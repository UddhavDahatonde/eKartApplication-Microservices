﻿namespace Auth.Core.Dto
{
    public class UserDto
    {
        public Guid UserId { get; set; }
        public string? Email { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
