using GreenCorner.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace GreenCorner.Views;

public partial class ArticlePage : ContentPage
{
	public ArticlePage() : this(App.Services.GetRequiredService<ArticleViewModel>())
	{
	}

	public ArticlePage(ArticleViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
