using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GreenCorner.Models;
using GreenCorner.Services;

namespace GreenCorner.ViewModels;

[QueryProperty(nameof(Plant), "Plant")]
public partial class ProductDetailsViewModel : ObservableObject
{
    private readonly CartService _cartService;

    [ObservableProperty]
    Plant plant;

    [ObservableProperty]
    string addToCartText = "Add to Cart";

    [ObservableProperty]
    bool isAddedToCart;

    public ProductDetailsViewModel(CartService cartService)
    {
        _cartService = cartService;
    }

    [RelayCommand]
    void AddToCart()
    {
        if (Plant != null)
        {
            _cartService.AddToCart(Plant);
            IsAddedToCart = true;
            AddToCartText = "Added!";
            
            // Revert state after a delay or keep it - for now just leave it
            // Could use a timer to reset button text
        }
    }

    [RelayCommand]
    async Task GoBack()
    {
        await Shell.Current.GoToAsync("..");
    }
}
