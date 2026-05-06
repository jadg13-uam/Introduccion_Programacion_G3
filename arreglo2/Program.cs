//Crea un arreglo de notas de 15 estudiantes, luego calcula el promedio de las notas, y los 3 primeros lugares. no se puede ingresar notas menores a 0 ni mayores a 100.

int[] notas = new int[15];
int suma = 0,  contError = 0;
double promedio = 0;

for (int i = 0; i < notas.Length; i++)
{
    if (contError >= 3)
    {
        Console.ForegroundColor =  ConsoleColor.DarkRed;
        Console.WriteLine("Has comitido muchos errores, es normal, te recomiendo descansar y volver a iniciar.");
        contError=0;
        Console.ResetColor();
    }
    try
    {
        Console.WriteLine($"Ingrese la nota del estudiante {i + 1}: ");
        int nota = int.Parse(Console.ReadLine());

        if (nota < 0 || nota > 100)
        {
            throw new ArgumentOutOfRangeException("La nota debe ser entre 0 y 100.");
        }

        notas[i] = nota;
        
    }
    catch (FormatException)
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
        i--; // Decrementar para volver a pedir la nota del mismo estudiante
        contError++;
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine(ex.Message);
        i--; // Decrementar para volver a pedir la nota del mismo estudiante
        contError++;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ocurrió un error: {ex.Message}");
        i--; // Decrementar para volver a pedir la nota del mismo estudiante
        contError++;
    }
}

foreach(int nota in notas)
{
    suma += nota;
}
Console.WriteLine($"Suma: {suma}");
Console.WriteLine($"Cantidad de notas: {notas.Length}");

promedio = suma / notas.Length;

Console.WriteLine($"Promedio: {promedio}");

Array.Sort(notas);
Array.Reverse(notas);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Cuadro de Honor");
for(int i = 0; i <3; i++)
{
    Console.WriteLine(notas[i]);
}
Console.ResetColor();

