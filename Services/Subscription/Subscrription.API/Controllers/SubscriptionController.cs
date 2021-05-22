using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Subscription.API.Infrastructure;
using Subscription.API.Models;
using Subscription.API.Service;

namespace Subscrription.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionController : ControllerBase
    {
        private readonly ISubscriptionService subscriptionService;
        public SubscriptionController(ISubscriptionService SubscriptionService)
        {
            subscriptionService = SubscriptionService;
        }

        [HttpGet("{id}")]
        public SubscriptionDTO GetSubscription(int id)
        {
            return subscriptionService.GetSubscriptionInfoById(id);
        }
    }
}
