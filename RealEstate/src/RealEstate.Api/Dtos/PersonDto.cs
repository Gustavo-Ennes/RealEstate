#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

using RealEstate.Api.Dtos.Base;

namespace RealEstate.Api.Dtos;

public class CreatePersonDto
{
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Name { get; set; }
    public CreateAddressDto Address { get; set; }
}

public class UpdatePersonDto : UpdateBaseDto
{
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Name { get; set; }
    public UpdateAddressDto? Address { get; set; }
}
