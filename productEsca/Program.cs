int[] vectorA = new int[5];
int[] vectorB = new int[5];
int productoEscalar = 0;

Console.WriteLine("--- Cálculo del Producto Escalar ---");

Console.WriteLine("\nIngrese los elementos del Vector A:");
for (int i = 0; i < vectorA.Length; i++)
{
    try
    {
        Console.Write($"Elemento A {i + 1}: ");
        vectorA[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: Ingrese un número entero válido.");
        Console.ResetColor();
        i--;
    }
}

Console.WriteLine("\nIngrese los elementos del Vector B:");
for (int i = 0; i < vectorB.Length; i++)
{
    try
    {
        Console.Write($"Elemento B {i + 1}: ");
        vectorB[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: Ingrese un número entero válido.");
        Console.ResetColor();
        i--;
    }
}
for (int i = 0; i < vectorA.Length; i++)
{
    productoEscalar += vectorA[i] * vectorB[i];
}

// 5. Mostrar el producto escalar total
Console.WriteLine("\n-------------------------------------------");
Console.WriteLine($"El producto escalar total es: {productoEscalar}");
Console.WriteLine("-------------------------------------------");