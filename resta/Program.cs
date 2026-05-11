//resta vectores

using System.Numerics;

int[] vector1 = new int [5];
int[] vector2 = new int [5];
int[] restaVector = new int [5];

Console.WriteLine("----Inserte los valores del primer vector----");
for (int i =0; i < vector1.Length; i++)
try
{
    Console.Write($"Elemento {i + 1}: ");
    vector1[i] = int.Parse(Console.ReadLine()!);

}
catch (FormatException)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Valor no válido. Por favor ingrese un número entero");
    Console.ResetColor();
    i--;
}
Console.WriteLine("----Ingrese los elementos del segundo vector----");
for (int i = 0; i < vector2.Length; i++)
try
{
    Console.Write($"Elemento {i + 1}: ");
    vector1[i] = int.Parse(Console.ReadLine()!);

}
catch (FormatException)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Valor no válido. Por favor ingrese un número entero");
    Console.ResetColor();
    i--;    
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nEl resultado de la resta es:");
Console.ResetColor();
for (int i = 0; i < vector1.Length; i++)
{
    restaVector[i] = vector1[i] - vector2[i];
}
for (int i = 0; i < restaVector.Length; i++)
{
    Console.WriteLine($"Elemento {i + 1}: {restaVector[i]}");
}
