using Microsoft.Extensions.Logging;

namespace GreenCorner
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
        
        // Services
        builder.Services.AddSingleton<Services.PlantService>();
        builder.Services.AddSingleton<Services.BlogService>();
        builder.Services.AddSingleton<Services.CartService>();

        // ViewModels & Pages
        builder.Services.AddTransient<ViewModels.HomeViewModel>();
        builder.Services.AddTransient<Views.HomePage>();

        builder.Services.AddTransient<ViewModels.CatalogViewModel>();
        builder.Services.AddTransient<Views.CatalogPage>();

        builder.Services.AddTransient<ViewModels.ProductDetailsViewModel>();
        builder.Services.AddTransient<Views.ProductDetailsPage>();

        builder.Services.AddTransient<ViewModels.BlogViewModel>();
        builder.Services.AddTransient<Views.BlogPage>();

        builder.Services.AddTransient<ViewModels.ArticleViewModel>();
        builder.Services.AddTransient<Views.ArticlePage>();

        builder.Services.AddTransient<ViewModels.CartViewModel>();
        builder.Services.AddTransient<Views.CartPage>();

        builder.Services.AddTransient<Views.AboutPage>();
        builder.Services.AddTransient<Views.ContactsPage>();

        return builder.Build();
        }
    }
}
