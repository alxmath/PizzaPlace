namespace PizzaPlace.Shared;

public class State
{
    public Menu Menu { get; } = new();
    public ShoppingBasket Basket { get; } = new();
    public UI UI { get; set; } = new();

    public decimal TotalPrice => Basket.Orders.Sum(id => Menu.GetPizza(id)!.Price);
}

