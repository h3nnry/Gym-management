namespace GymManagement.Application.Services;


public interface ISubscriptionsService
{
    public Guid CreateSubscription(string subscriptionType, Guid adminId);
}