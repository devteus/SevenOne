using Microsoft.EntityFrameworkCore;
using SevenOne.Repository.Context;

namespace SevenOne.Web;

public static class DependencyInjection
{
    public static WebApplicationBuilder ConfigureDi(this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<SevenOneContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("SevenOneConnectionStrings")),
                ServiceLifetime.Transient);

        return builder;
    }
}
