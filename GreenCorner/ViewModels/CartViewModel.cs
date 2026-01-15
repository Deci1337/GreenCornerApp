using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GreenCorner.Models;
using GreenCorner.Services;
using System.Collections.ObjectModel;
using System.Linq;

namespace GreenCorner.ViewModels;

public partial class CartViewModel : ObservableObject
{
    private readonly CartService _cartService;

    public ObservableCollection<CartItem> CartItems => _cartService.CartItems;

    [ObservableProperty]
    decimal totalAmount;

    public CartViewModel(CartService cartService)
    {
        _cartService = cartService;
        _cartService.CartItems.CollectionChanged += CartItems_CollectionChanged;
        UpdateTotal();
    }

    private void CartItems_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
    {
        UpdateTotal();
    }

    void UpdateTotal()
    {
        TotalAmount = CartItems.Sum(i => i.Plant.Price * i.Quantity);
    }

    [RelayCommand]
    void RemoveItem(CartItem item)
    {
        _cartService.CartItems.Remove(item);
    }

    [RelayCommand]
    async Task Checkout()
    {
        if (CartItems.Count == 0)
        {
            await Shell.Current.DisplayAlert("Empty Cart", "Add some plants first!", "OK");
            return;
        }

        await Shell.Current.DisplayAlert("Checkout", $"Processing payment of ${TotalAmount:F2}...", "OK");
        _cartService.ClearCart();
    }
}
