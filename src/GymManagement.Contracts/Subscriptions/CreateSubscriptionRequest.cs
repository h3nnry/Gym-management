namespace GymManagement.Contracts.Subscriptions;

public record CreateSubscriptionbRequest(SubscriptionType SubscriptionType, Guid AdminId);