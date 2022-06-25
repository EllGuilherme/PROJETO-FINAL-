string opcaoDesejada;

Console.Clear();

Console.WriteLine("--- Calculadora 7 operações ---\n");

Console.WriteLine("[+] Soma");
Console.WriteLine("[-] Subtração");
Console.WriteLine("[x] Multiplicação");
Console.WriteLine("[/] Divisão");
Console.WriteLine("[%] porcentagem ");
Console.WriteLine("[e] Exponenciação");
Console.WriteLine("[r] radiciação");

Console.Write("\nSelecione a operação desejada: ");

opcaoDesejada = Console.ReadLine()!;

switch (opcaoDesejada)
{
    case "+":
        Codigo.CalcularSoma();
        break;

    case "-":
        Codigo.CalcularSubtracao();
        break;

    case "x":
        Codigo.CalcularMultiplicacao();
        break;

    case "/":
        Codigo.CalcularDivisao();
        break;

    case "e":
        Codigo.CalcularExponenciacao();
        break;

    case "r":
        Codigo.Calcularradiciacao();
        break;

    default:
        Console.WriteLine("Opção inválida.");
        break;
   
    case "%":
        Codigo.CalcularPorcentagem();
        break;
}
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("PROGAMA FEITO POR GUILHERME RIBEIRO DE SOUZA-1I3-");
Console.ResetColor();

Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("OBRIGADO POR UTILIZAR ESTA PROGAMA");
Console.ResetColor();


Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("<3-----");
Console.ResetColor();