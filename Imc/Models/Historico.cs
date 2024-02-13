using Imc.Enums;

namespace Imc.Models;

public class Historico(StatusPeso statusPeso, DateTime dataInclusao, string? descricao)
{
    public StatusPeso StatusPeso { get; set; } = statusPeso;
    public DateTime DataInclusao { get; set; } = dataInclusao;
    public string? Descricao { get; set; } = descricao;
}
