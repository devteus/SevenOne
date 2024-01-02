using Microsoft.EntityFrameworkCore;

namespace SevenOne.Repository.Context;

public class SevenOneContext : DbContext
{
    public SevenOneContext(DbContextOptions<SevenOneContext> options)
            : base(options)
    {
    }
}
