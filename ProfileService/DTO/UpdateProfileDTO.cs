﻿namespace ProfileService.DTO;

public class UpdateProfileDTO
{
    public IFormFile Icon { get; set; }
    public IFormFile Bg { get; set; }
    public string LastName { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Description { get; set; } = "Empty";
    public string UniversityName { get; set; }

}
