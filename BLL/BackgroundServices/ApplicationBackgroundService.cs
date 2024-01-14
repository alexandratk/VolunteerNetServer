using AutoMapper;
using BLL.Interfaces;
using DAL.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BackgroundServices
{
    public class ApplicationBackgroundService : BackgroundService
    {
        public IServiceProvider Services { get; }

        public ApplicationBackgroundService(IServiceProvider services)
        {
            Services = services;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            TimeSpan timeSpan = new TimeSpan(12, 0, 0);
            //while (!stoppingToken.IsCancellationRequested)
            //{
            //    using (var scope = Services.CreateScope())
            //    {
            //        var applicationService =
            //            scope.ServiceProvider
            //                .GetRequiredService<IApplicationService>();

            //        await applicationService.CompleteApplicationBackgroundService();
            //    }
            //    await Task.Delay(timeSpan, stoppingToken);
            //}
        }
    }
}
