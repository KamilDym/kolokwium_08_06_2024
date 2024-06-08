using WebApplication1.Models;

namespace WebApplication1.DTOs;


public class FullClientDto
{   
    public int idClient { get; set; }
    public string fistName { get; set; }
    public string lastName { get; set; }
    public string email { get; set; }
    public string phone { get; set; }
    public List<ClientSubscriptionDto> subscriptions { get; set; }
}
public class ClientDto
{
    public string fistName { get; set; }
    public string lastName { get; set; }
    public string email { get; set; }
    public string phone { get; set; }
    public List<ClientSubscriptionDto> subscriptions { get; set; }
}

public class ClientSubscriptionDto
{
    public int IdSubscription { get; set; }
    public string Name { get; set; }
    public decimal TotalPaidAmount { get; set; }
}