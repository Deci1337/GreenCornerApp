using GreenCorner.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace GreenCorner.Views;

public partial class ProductDetailsPage : ContentPage
{
	public ProductDetailsPage() : this(App.Services.GetRequiredService<ProductDetailsViewModel>())
	{
	}

	public ProductDetailsPage(ProductDetailsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
