using GymManagement.Application.Services;
using GymManagement.Contracts.Subscriptions;
using Microsoft.AspNetCore.Mvc;

namespace GymManagement.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SubscriptionsController : ControllerBase
{
    private readonly ISubscriptionsService _subscriptionService;

    public SubscriptionsController(ISubscriptionsService subscriptionService)
    {
        _subscriptionService = subscriptionService;
    }

    [HttpPost(Name = "GetWeatherForecasddt")]
    public IActionResult CreateSubscription(CreateSubscriptionbRequest request)
    {
        var subscriptionId = _subscriptionService.CreateSubscription(
            request.SubscriptionType.ToString(),
            request.AdminId
            );

        var response = new SubscriptionResponse(subscriptionId, request.SubscriptionType);

        return Ok(response);
    }

}