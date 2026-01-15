using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GreenCorner.Models;

namespace GreenCorner.ViewModels;

[QueryProperty(nameof(Post), "Post")]
public partial class ArticleViewModel : ObservableObject
{
    [ObservableProperty]
    Post post;

    [RelayCommand]
    async Task GoBack()
    {
        await Shell.Current.GoToAsync("..");
    }
}
