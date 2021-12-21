namespace PizzaPlace.Shared;

public class Menu
{
    public List<Pizza> Pizzas { get; set; } = new();

    public void Add(Pizza pizza) => Pizzas.Add(pizza);

    public Pizza? GetPizza(int id) =>
        Pizzas.SingleOrDefault(p => p.Id == id);
}
