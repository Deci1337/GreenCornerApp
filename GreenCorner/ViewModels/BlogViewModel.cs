using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GreenCorner.Models;
using GreenCorner.Services;
using System.Collections.ObjectModel;

namespace GreenCorner.ViewModels;

public partial class BlogViewModel : ObservableObject
{
    private readonly BlogService _blogService;

    [ObservableProperty]
    ObservableCollection<Post> posts;

    public BlogViewModel(BlogService blogService)
    {
        _blogService = blogService;
        Posts = new ObservableCollection<Post>(_blogService.GetPosts());
    }

    [RelayCommand]
    async Task GoToArticle(Post post)
    {
        if (post == null) return;

        var navigationParameter = new Dictionary<string, object>
        {
            { "Post", post }
        };
        await Shell.Current.GoToAsync($"ArticlePage", navigationParameter);
    }
}
