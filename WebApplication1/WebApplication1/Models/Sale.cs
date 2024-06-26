﻿namespace WebApplication1.Models;

public class Sale
{
    public int IdSale { get; set; }
    public int IdClient { get; set; }
    public int IdSubscription { get; set; }
    public DateTime CreatedAt { get; set; }
    
    public virtual Client ClientNavogator { get; set; }
    public virtual Subscription SubscriptionNavigator { get; set; }
}