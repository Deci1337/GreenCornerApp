using GreenCorner.Views;

namespace GreenCorner;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(ProductDetailsPage), typeof(ProductDetailsPage));
        Routing.RegisterRoute(nameof(ArticlePage), typeof(ArticlePage));
        // Register other routes here as needed
        // Routing.RegisterRoute(nameof(ArticlePage), typeof(ArticlePage));
	}
}
