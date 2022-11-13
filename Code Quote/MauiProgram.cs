namespace Code_Quote
{
    public static class MauiProgram
    {
        //public static string apiKey;
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Lobster-Regular.ttf", "MyFont");
                });

            //get api key from secret manager
            //apiKey = builder.Configuration["AppKeyTranslate"];

            return builder.Build();
        }
    }
}