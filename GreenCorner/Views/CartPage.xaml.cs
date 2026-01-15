using GreenCorner.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace GreenCorner.Views;

public partial class CartPage : ContentPage
{
	public CartPage() : this(App.Services.GetRequiredService<CartViewModel>())
	{
	}

	public CartPage(CartViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
