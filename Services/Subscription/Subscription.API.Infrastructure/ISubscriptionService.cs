using Subscription.API.Models;

namespace Subscription.API.Infrastructure
{
    public interface ISubscriptionService
    {
         SubscriptionDTO GetSubscriptionInfoById(int id);
    }
}