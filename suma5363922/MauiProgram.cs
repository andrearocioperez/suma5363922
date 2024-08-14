using Microsoft.Extensions.Logging;

namespace suma5363922
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
            builder.Services.AddSingleton<LocalDbService>();
            builder.Services.AddTransient<MainPage>();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
