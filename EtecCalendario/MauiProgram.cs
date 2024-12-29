using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;

namespace EtecCalendario
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>().ConfigureFonts(fonts =>
            {
                
            }).UseMauiCommunityToolkit();
            return builder.Build();
        }
    }
}