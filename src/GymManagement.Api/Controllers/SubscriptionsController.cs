using GymManagement.Application.Subscriptions.Commands.CreateSubscription;
using GymManagement.Contracts.Subscriptions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GymManagement.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SubscriptionsController : ControllerBase
{
    private readonly IMediator _mediator;

    public SubscriptionsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost(Name = "GetWeatherForecasddt")]
    public async Task<IActionResult> CreateSubscription(CreateSubscriptionbRequest request)
    {
        var command = new CreateSubscriptionCommand(
            request.SubscriptionType.ToString(), 
            request.AdminId
            );
        var subscriptionId = await _mediator.Send(command);

        var response = new SubscriptionResponse(subscriptionId, request.SubscriptionType);

        return Ok(response);
    }

}