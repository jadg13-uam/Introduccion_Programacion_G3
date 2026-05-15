//Multiplicación de matriz por escalar
int k = 0;
int [,] matriz = new int[3, 3];

Console.WriteLine("Llenar Matiz");
for(int i = 0; i < 3; i++)
{
    for(int j = 0; j < 3; j++)
    {
        try{
        Console.Write($"Elemento {i}, {j}: ");
        matriz[i, j] = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Solo se permiten valores enteros. Por favor vuelva a intentar.");
            j--;
            Console.ResetColor();
        }
    }
}

/*Mostrar matriz*/
Console.WriteLine("Matriz");
for(int f = 0; f < 3; f++)
{
    for(int c = 0; c < 3; c++)
    {
        Console.Write($" {matriz[f, c]} ");
    }
    Console.WriteLine();
}

/* Multiplicar por el escalar */

Console.Write("Dime el valor de escalar: ");
k = int.Parse(Console.ReadLine());


for(int i = 0; i < 3; i++)
{
    for(int j = 0; j < 3; j++)
    {
        
        matriz[i, j] = matriz[i,j] *k;
    }
}

/* Mostrar matriz*/
Console.WriteLine("Matriz");
for(int f = 0; f < 3; f++)
{
    for(int c = 0; c < 3; c++)
    {
        Console.Write($" {matriz[f, c]} ");
    }
    Console.WriteLine();
}