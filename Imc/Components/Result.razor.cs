using Microsoft.AspNetCore.Components;

namespace Imc.Components;

public partial class Result
{
    [Parameter]
    public EventCallback OnCloseModal { get; set; }
    [Parameter]
    public bool ResultadoImc { get; set; }

    private void CloseModal()
    {
        OnCloseModal.InvokeAsync();
    }

    private void AvancarProximaPagina(string rota)
    {
        NavigationManager.NavigateTo(rota);
    }
}
