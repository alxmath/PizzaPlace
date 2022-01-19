using Microsoft.AspNetCore.Mvc;
using PizzaPlace.Shared;

namespace PizzaPlace.Server.Pages
{
    [ApiController]
    [Route("api/[controller]")]
    public class PizzasController : Controller
    {
        private readonly PizzaPlaceDbContext _db;

        public PizzasController(PizzaPlaceDbContext db)
        {
            _db = db;
        }

        [HttpGet("/pizzas")]
        public IQueryable<Pizza> GetPizzas() =>
            _db.Pizzas;


        [HttpPost("/pizzas")]
        public IActionResult InsertPizza([FromBody] Pizza pizza)
        {
            _db.Pizzas.Add(pizza);
            _db.SaveChanges();
            return Created($"pizzas/{pizza.Id}", pizza);
        }
    }
}
