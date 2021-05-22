using System;
using Subscription.API.Infrastructure;
using Subscription.API.Models;

namespace Subscription.API.Service
{
    public class SubscriptionService : ISubscriptionService
    {
        public SubscriptionDTO GetSubscriptionInfoById(int id)
        {
            return new SubscriptionDTO()
            {
                Id = id,
                Name = "Netflix",
                Amount = new Random().Next(100),
                RenewelDate = DateTime.Now.AddDays(30)
            };
        }
    }
}