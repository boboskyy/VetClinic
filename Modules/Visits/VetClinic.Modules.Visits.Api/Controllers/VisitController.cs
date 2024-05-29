using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VetClinic.Modules.Visits.Application.Commands.ChangeVisit;
using VetClinic.Modules.Visits.Application.Commands.CreateVisit;
using VetClinic.Modules.Visits.Application.Commands.RemoveVisit;
using VetClinic.Modules.Visits.Application.Queries.Browse;
using VetClinic.Modules.Visits.Application.Queries.GetVisitById;

namespace VetClinic.Modules.Visits.Api.Controllers;

[ApiController]
[Route("visits")]
public class VisitController : ControllerBase
{
    private readonly ISender _sender;
    
    public VisitController(ISender sender)
    {
        _sender = sender;
    }
    
    [HttpGet()]
    public async Task<IActionResult> GetById([FromQuery] Guid id)
    {
        var query = new GetVisitByIdQuery { Id = id };
        var organizations = await _sender.Send(query);
        return Ok(organizations);
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateVisit([FromBody] CreateVisitCommand command)
    {
        await _sender.Send(command);
        return Ok();
    }
    
    
    [HttpPut("{visitId}")]
    public async Task<IActionResult> ChangeVisit([FromRoute] Guid visitId, [FromBody] ChangeVisitCommand command)
    {
        command.VisitId = visitId;
        await _sender.Send(command);
        return Ok();
    }

    [HttpDelete("{visitId}")]
    public async Task<IActionResult> DeleteVisit([FromRoute] Guid visitId)
    {
        var command = new RemoveVisitCommand(visitId);
        await _sender.Send(command);
        return NoContent();
    }
    
    [HttpGet("browse")]
    public async Task<IActionResult> Browse()
    {
        var query = new BrowseVisitsQuery();
        var visits = await _sender.Send(query);
        return Ok(visits);
    }
}