using GreenCorner.ViewModels;

namespace GreenCorner.Views;

public partial class ArticlePage : ContentPage
{
	public ArticlePage(ArticleViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
