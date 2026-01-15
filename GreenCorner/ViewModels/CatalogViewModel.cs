using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GreenCorner.Models;
using GreenCorner.Services;
using System.Collections.ObjectModel;
using System.Linq;

namespace GreenCorner.ViewModels;

public partial class CatalogViewModel : ObservableObject
{
    private readonly PlantService _plantService;
    private List<Plant> _allPlants;

    [ObservableProperty]
    ObservableCollection<Plant> filteredPlants;

    [ObservableProperty]
    string selectedFilter = "All";

    public CatalogViewModel(PlantService plantService)
    {
        _plantService = plantService;
        _allPlants = _plantService.GetPlants();
        FilteredPlants = new ObservableCollection<Plant>(_allPlants);
    }

    [RelayCommand]
    void FilterBy(string difficulty)
    {
        SelectedFilter = difficulty;
        if (difficulty == "All")
        {
            FilteredPlants = new ObservableCollection<Plant>(_allPlants);
        }
        else
        {
            FilteredPlants = new ObservableCollection<Plant>(_allPlants.Where(p => p.Difficulty == difficulty));
        }
    }

    [RelayCommand]
    async Task GoToDetails(Plant plant)
    {
        if (plant == null) return;
        
        var navigationParameter = new Dictionary<string, object>
        {
            { "Plant", plant }
        };
        await Shell.Current.GoToAsync($"ProductDetailsPage", navigationParameter);
    }
}
