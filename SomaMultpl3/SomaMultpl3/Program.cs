// See https://aka.ms/new-console-template for more information
int numero = 0;

for(int i = 1; i<=100; i++)
{
    if (i % 3 == 0)
    {
        
        Console.WriteLine($"{numero} + {i} = {numero += i}");
    }
}
Console.WriteLine($"\n\n\nValor total: {numero}");
