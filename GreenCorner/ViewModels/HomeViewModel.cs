using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GreenCorner.Models;
using GreenCorner.Services;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace GreenCorner.ViewModels;

public partial class HomeViewModel : ObservableObject
{
    private readonly PlantService _plantService;

    [ObservableProperty]
    ObservableCollection<Plant> popularPlants;

    public HomeViewModel(PlantService plantService)
    {
        _plantService = plantService;
        PopularPlants = new ObservableCollection<Plant>(_plantService.GetPopularPlants());
    }

    [RelayCommand]
    async Task GoToCatalog()
    {
        // Navigation to Catalog will be implemented later
        await Shell.Current.DisplayAlert("Info", "Navigate to Catalog", "OK");
    }

    [RelayCommand]
    async Task GoToBlog()
    {
         // Navigation to Blog will be implemented later
        await Shell.Current.DisplayAlert("Info", "Navigate to Blog", "OK");
    }
}
