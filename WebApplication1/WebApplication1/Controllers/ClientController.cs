using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;
using WebApplication1.DTOs;

namespace WebApplication1.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class ClientController : ControllerBase
{
    private readonly AppDbContext _context;

    public ClientController(AppDbContext context)
    {
        _context = context;
    }
    
    // [HttpGet("{id}")]
    [HttpGet]
    public async Task<ActionResult> GetClientSubscription()
    {
        var client = await _context.Client.Select(e=> new ClientDto()
        {
            fistName = e.FirstName,
            lastName = e.LastName,
            email = e.Email,
            phone = e.Phone,
        }).ToListAsync();

        return Ok(client);
    }

}