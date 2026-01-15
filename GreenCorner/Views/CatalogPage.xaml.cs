using GreenCorner.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace GreenCorner.Views;

public partial class CatalogPage : ContentPage
{
	public CatalogPage() : this(App.Services.GetRequiredService<CatalogViewModel>())
	{
	}

	public CatalogPage(CatalogViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
