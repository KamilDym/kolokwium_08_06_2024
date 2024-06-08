namespace WebApplication1.Models;

public class Payment
{
    public int IdPayment { get; set; }
    public DateTime Date { get; set; }
    public int IdClient { get; set; }
    public int IdSubscription { get; set; }
    
    public virtual Client ClientNavigator { get; set; }
    public virtual Subscription SubscriptionNavigator { get; set; }
    
}
