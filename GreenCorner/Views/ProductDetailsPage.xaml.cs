using GreenCorner.ViewModels;

namespace GreenCorner.Views;

public partial class ProductDetailsPage : ContentPage
{
	public ProductDetailsPage(ProductDetailsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
