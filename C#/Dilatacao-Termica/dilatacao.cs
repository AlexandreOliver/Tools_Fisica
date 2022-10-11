using System;
using System.Globalization;

class Dilatacao
{
    static void Main()
    {
        double cof_Dilatacao, dilatacao, tamInicial, tamFinal, variacaoTemperatura;
        string solido;

        Console.WriteLine("------------- Dilatação Linear -------------");
        Console.Write("Nome do Solido: "); 
        solido = Console.ReadLine();
        Console.Write("Coeficiente de Dilatação Linear: "); 
        cof_Dilatacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Tamanho Inicial(m): ");
        tamInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Variação de Temperatura: "); 
        variacaoTemperatura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        dilatacao = tamInicial * variacaoTemperatura * cof_Dilatacao;
        tamFinal = tamInicial + dilatacao;

        Console.WriteLine("\n\tSolido: {0}", solido);
        Console.WriteLine("Dilatação..........: {0,10}m", dilatacao.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("Tamanho Final......: {0,10}m", tamFinal.ToString("F4", CultureInfo.InvariantCulture));


        Console.ReadLine();

    }
}