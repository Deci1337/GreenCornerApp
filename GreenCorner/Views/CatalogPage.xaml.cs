using GreenCorner.ViewModels;

namespace GreenCorner.Views;

public partial class CatalogPage : ContentPage
{
	public CatalogPage(CatalogViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
