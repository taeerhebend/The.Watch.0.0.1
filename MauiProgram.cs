﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Hosting;
using TheWatch.Services;
using Microsoft.Extensions.Http;

namespace TheWatch
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            // Add IApiService and ApiService registration as HttpClient

            builder.Services.AddHttpClient<_IApiService, _ApiService>(
                client => 
                {
                    client.BaseAddress = new Uri("https://localhost.com");
                });
            
            
            return builder.Build();
        }
    }
}