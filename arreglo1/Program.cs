/* Almacenar 10 edades en un arreglo, luego calcular el promedio de edades, el maximo y el minimo.*/
//crear arreglo de edades
int[] edades = new int[10];

//Pedir edades
for(int i = 0; i < edades.Length; i++)
{
    try
    {
        Console.WriteLine("Digite la edad " + (i + 1) + ":");
        edades[i] = int.Parse(Console.ReadLine());
    }
    catch
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
        i--; // Reintentar la misma posición
        Console.ResetColor();
    }
}

//Calcular promedio, maximo y minimo
int suma = 0, maximo = edades[0], minimo = edades[0];

foreach(int edad in edades)
{
    suma += edad;
    if(edad > maximo)
        maximo = edad;
    if(edad < minimo)
        minimo = edad;
}

double promedio = (double)suma / edades.Length;

//Mostrar resultados
Console.WriteLine("El promedio de edades es: " + promedio);
Console.WriteLine("La edad máxima es: " + maximo);
Console.WriteLine("La edad mínima es: " + minimo);
