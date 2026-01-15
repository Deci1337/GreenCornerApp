using GreenCorner.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace GreenCorner.Views;

public partial class BlogPage : ContentPage
{
    public BlogPage() : this(App.Services.GetRequiredService<BlogViewModel>())
    {
    }

    public BlogPage(BlogViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}


