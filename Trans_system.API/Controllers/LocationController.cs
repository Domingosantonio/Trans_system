using Microsoft.AspNetCore.Mvc;
using Trans_system.Application.DTOs;
using Trans_system.Application.Features.Locations.Commands.Interfaces;

namespace Trans_system.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class LocationController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromServices] IRegisterLocationCommand request, [FromBody] LocationDTO  locationDTO)
    {
       request.Register(locationDTO);
        return Created();
    }
}
