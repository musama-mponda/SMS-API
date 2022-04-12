using Microsoft.EntityFrameworkCore;
using SMS_API.Entities;

namespace SMS_API.Models;

public class MessageDbContext : DbContext
{
    public MessageDbContext(DbContextOptions<MessageDbContext> options) : base(options){}
    
    public DbSet<Messages> Messages { get; set; }
}