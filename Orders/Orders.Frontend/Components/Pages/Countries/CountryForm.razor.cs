using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Orders.Shared.Entities;

namespace Orders.Frontend.Components.Pages.Countries;

public partial class CountryForm
{
    private EditContext editContext = null!;

    [EditorRequired, Parameter] public Country Country { get; set; } = null!;
    [EditorRequired, Parameter] public EventCallback OnValidSubmit { get; set; }
    [EditorRequired, Parameter] public EventCallback ReturnAction { get; set; }

    protected override void OnInitialized()
    {
        editContext = new(Country);
    }
}