int[] V = new int[5];
double sumaCuadrados = 0;

Console.WriteLine("--- Cálculo de Magnitud de un Vector ---");
Console.WriteLine("Ingrese los 5 componentes del vector:");

for (int i = 0; i < V.Length; i++)
{
    try
    {
        Console.Write($"Componente {i + 1}: ");
        V[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada no válida, por favor, ingrese un número entero.");
        Console.ResetColor();
        i--; 
    }
}

for (int i = 0; i < V.Length; i++)
{
    sumaCuadrados += Math.Pow(V[i], 2);
}

double magnitud = Math.Sqrt(sumaCuadrados);

Console.WriteLine("\nLa magnitud total del vector es:");
Console.WriteLine(magnitud);