﻿namespace WebApplication1.Models;

public class Discount
{
    public int IdDiscount { get; set; }
    public decimal Value { get; set; }
    public int IdSubscription { get; set; }
    public DateTime DateFrom { get; set; }
    public DateTime DateTo { get; set; }
    
    public virtual Subscription SubscriptionNavigator { get; set; }
}