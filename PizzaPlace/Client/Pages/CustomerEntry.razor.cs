using Microsoft.AspNetCore.Components;
using PizzaPlace.Shared;

namespace PizzaPlace.Client.Pages;

public partial class CustomerEntry
{
    [Parameter]
    public string Title { get; set; } = default!;

    [Parameter]
    public string ButtonTitle { get; set; } = default!;

    [Parameter]
    public string ButtonClass { get; set; } = default!;

    [Parameter]
    public Customer Customer { get; set; } = default!;

    [Parameter]
    public EventCallback ValidSubmit { get; set; } = default!;
}
