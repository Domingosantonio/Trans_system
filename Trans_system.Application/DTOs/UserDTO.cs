﻿namespace Trans_system.Application.DTOs;
public class UserDTO
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public bool? IsActive { get; set; }
}
