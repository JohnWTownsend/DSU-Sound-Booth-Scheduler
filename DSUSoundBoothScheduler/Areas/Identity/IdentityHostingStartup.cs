using System;
using Data;
using DSUSoundBoothScheduler.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(DSUSoundBoothScheduler.Areas.Identity.IdentityHostingStartup))]
namespace DSUSoundBoothScheduler.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<DSUSoundBoothSchedulerContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DSUSoundBoothSchedulerContextConnection")));

                services.AddDefaultIdentity<DSUSoundBoothSchedulerUser>()
                    .AddEntityFrameworkStores<DSUSoundBoothSchedulerContext>();
            });
        }
    }
}