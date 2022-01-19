using Microsoft.AspNetCore.Mvc;
using PizzaPlace.Shared;

namespace PizzaPlace.Server.Pages
{
    [ApiController]
    [Route("api/[controller]")]
    public class PizzasController : Controller
    {
        private static readonly List<Pizza> _pizza = new()
        {
            new Pizza(1, "Pepperoni", 8.99M, Spiciness.Spicy),
            new Pizza(2, "Margarita", 7.99M, Spiciness.None),
            new Pizza(3, "Diabolo", 9.99M, Spiciness.Hot),
        };

        [HttpGet("/pizzas")]
        public IQueryable<Pizza> GetPizzas() =>
            _pizza.AsQueryable();
    }
}
