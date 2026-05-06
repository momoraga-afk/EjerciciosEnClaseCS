//Leer 5 edades y mostrar la edad promedio 

int[] edades = new int[5];
int suma = 0;
double promedio = 0;

for (int i= 0; 1 < edades.Length; i++)
{
    try
    {
    Console.WriteLine("Dime la edad " + (i + 1) + ":");
    edades[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
    Console.WriteLine("Por favor, ingresa un número válido para la edad.");
    i--; // Decrementar el índice para volver a solicitar la edadc
    }
    Console.WriteLine("Dime la edad " + (i + 1) + ":");
    edades[i] = int.Parse(Console.ReadLine()!);
    suma += edades[i];
}

foreach (int edad in edades)
{
    suma += edad;
}
promedio = (double)suma / edades.Length;
Console.WriteLine("El promedio de las edades es: " + promedio);
Console.ReadKey();