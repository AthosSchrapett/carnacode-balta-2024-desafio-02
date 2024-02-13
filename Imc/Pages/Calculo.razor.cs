using Imc.Models;

namespace Imc.Pages;

public partial class Calculo
{
    public bool modalAberta = false;
    CalculoImc calculo = new CalculoImc();

    private void OpenModal()
    {
        modalAberta = true;
        IncluiNovoHistorico();
    }

    private void CloseModal()
    {
        modalAberta = false;
    }

    private bool buttonHabilitado()
    {
        return calculo.Altura > 0 && calculo.Peso > 0 && calculo.Sexo != ' ';
    }

    private async Task IncluiNovoHistorico()
    {
        var historicos = await LocalStorageService.GetItemAsync<List<Models.Historico>>("historicos") ?? new List<Models.Historico>();
        historicos.Add(calculo.RetornaHistorico());
        await LocalStorageService.SetItemAsync<List<Models.Historico>>("historicos", historicos);
    }
}
