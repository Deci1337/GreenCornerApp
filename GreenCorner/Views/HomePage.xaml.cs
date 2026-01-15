using GreenCorner.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace GreenCorner.Views;

public partial class HomePage : ContentPage
{
	public HomePage() : this(App.Services.GetRequiredService<HomeViewModel>())
	{
	}

	public HomePage(HomeViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
