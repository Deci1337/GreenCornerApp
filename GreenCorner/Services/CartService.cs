using GreenCorner.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace GreenCorner.Services;

public class CartService
{
    public ObservableCollection<CartItem> CartItems { get; private set; } = new ObservableCollection<CartItem>();

    public void AddToCart(Plant plant)
    {
        var existingItem = CartItems.FirstOrDefault(i => i.Plant.Id == plant.Id);
        if (existingItem != null)
        {
            existingItem.Quantity++;
        }
        else
        {
            CartItems.Add(new CartItem { Plant = plant, Quantity = 1 });
        }
    }

    public void RemoveFromCart(Plant plant)
    {
        var existingItem = CartItems.FirstOrDefault(i => i.Plant.Id == plant.Id);
        if (existingItem != null)
        {
            CartItems.Remove(existingItem);
        }
    }

    public void ClearCart()
    {
        CartItems.Clear();
    }
}
