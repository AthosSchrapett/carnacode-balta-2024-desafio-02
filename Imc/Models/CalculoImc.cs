using Imc.Enums;

namespace Imc.Models;

public class CalculoImc
{
    public double? Altura { get; set; }
    public double? Peso { get; set; }
    public char Sexo { get; set; }
    public bool Idoso { get; set; }

    public bool ResultadoImc()
    {
        double imc = Peso.Value / (Altura.Value * Altura.Value);
        return imc < 24.9;
    }

    public Historico RetornaHistorico()
    {
        StatusPeso statusPeso = ResultadoImc() ? StatusPeso.PesoIdeal : StatusPeso.SobrePeso;       

        return new Historico(statusPeso, DateTime.Now, RetornaDescricaoHistorico(statusPeso));
    }

    private static string RetornaDescricaoHistorico(StatusPeso statusPeso)
    {
        return statusPeso == StatusPeso.PesoIdeal ?
            "Parabéns, você está no seu peso ideal, continue mantendo este estilo!" :
            "Estamos quase lá! Faça alguns ajustes para ficar no peso ideal!";
    }
}
