using System;

namespace Subscription.API.Models
{
    public class SubscriptionDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public DateTime RenewelDate { get; set; }
    }
}