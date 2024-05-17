//< 92 mg/dL (reavaliar entre 24 e 28 semanas com TTOG 75g de glicose)
//= ou > 92 mg/dL e < 126 mg/dL = Compatível com Diabetes Gestacional
//= ou > 126 mg/dL = Diabetes Mellitus na Gravidez

int glicemia;
string diagnostico;
ConsoleColor corExibicao;

Console.WriteLine("--- Diabetes Gestacional ---\n");

Console.Write("Glicemia (em mg/dL)...: ");
glicemia = Convert.ToInt32(Console.ReadLine());

if (glicemia > 126)
{
    diagnostico = "Cuidado! Diabetes Mellitus na gravidez";
    corExibicao = ConsoleColor.Red;
}
else
{
    if (glicemia >= 92)
    {
        diagnostico = "Compatível com Diabetes Gestacional";
        corExibicao = ConsoleColor.Green;
    }
    else
    {
        diagnostico = "Reavaliar entre 24 e 28 semanas com TTOG 75g de glicose";
        corExibicao = ConsoleColor.Blue;
    }
}

Console.ForegroundColor = corExibicao;

Console.WriteLine();
Console.WriteLine(diagnostico);

Console.ResetColor();